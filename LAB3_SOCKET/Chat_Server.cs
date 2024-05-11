using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB3_SOCKET
{
    public partial class Chat_Server : Form
    {
        private List<ClientConnection> clientConnections = new List<ClientConnection>();
        public Chat_Server()
        {
            InitializeComponent();

        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartSafeThread));
            serverThread.Start();
            btnListen.Enabled = false;
        }
        private void StartSafeThread()
        {
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(serverEndPoint);
            listenerSocket.Listen(-1);
            richCommand.AppendText("Server running on 127.0.0.1:8080\n");

            while (true)
            {
                Socket clientSocket = listenerSocket.Accept();
                HandleClient(clientSocket);
            }
        }

        private void HandleClient(Socket clientSocket)
        {
            Thread clientThread = new Thread(() =>
            {
                try
                {
                    string clientAddress = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                    int clientPort = ((IPEndPoint)clientSocket.RemoteEndPoint).Port;
                    richCommand.AppendText($"New client connected from: {clientAddress}: {clientPort}\n");

                    byte[] recvBuffer = new byte[1024];
                    string clientName = string.Empty;

                    while (true)
                    {
                        int bytesReceived = clientSocket.Receive(recvBuffer);
                        string message = Encoding.UTF8.GetString(recvBuffer, 0, bytesReceived);
                        message = message.Trim();
                        if (string.IsNullOrEmpty(clientName))
                        {
                            clientName = message;
                            string mess = clientAddress + ": " + clientPort + ": " + message + "\n"; 
                            clientConnections.Add(new ClientConnection(clientSocket, clientName));
                            richCommand.AppendText(mess);
                            BroadcastMessage($"{clientName}\n", clientSocket);
                        }
                        else
                        {
                            if (bytesReceived == 0)
                            {
                                // Client đã tắt kết nối
                                break;
                            }
                            string serverMessage = $"{clientAddress}: {clientPort}: {message}\n";
                            string mess = $"{message}\n";
                            richCommand.AppendText(serverMessage);
                            BroadcastMessage(mess, null);
                        }
                    }
                }
                catch (SocketException)
                {

                }
                finally
                {
                    clientSocket.Close();
                    clientConnections.RemoveAll(c => c.Socket == clientSocket);
                    BroadcastMessage($"Server: 1 Client has left the chat\n", null);
                }
            });

            clientThread.Start();
        }

        private void BroadcastMessage(string message, Socket senderSocket)
        {
            byte[] sendBuffer = Encoding.UTF8.GetBytes(message);

            foreach (var clientConnection in clientConnections)
            {
                //if (clientConnection.Socket != senderSocket && clientConnection.Socket.Connected)
                if (clientConnection.Socket.Connected)
                {
                    clientConnection.Socket.Send(sendBuffer);
                }
            }
        }
    }
    public class ClientConnection
    {
        public Socket Socket { get; private set; }
        public string ClientName { get; private set; }

        public ClientConnection(Socket socket, string clientName)
        {
            Socket = socket;
            ClientName = clientName;
        }
    }

}
