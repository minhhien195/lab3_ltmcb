using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SOCKET
{
    public partial class Bai2_TCP : Form
    {
        public Bai2_TCP()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverthread = new Thread(new ThreadStart(StartSafeThread));
            serverthread.Start();
            btnListen.Enabled = false;
        }

        void StartSafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1_024];
            Socket clientSocket;
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            richCommand.AppendText("New client connected\n");
            bytesReceived = NewMethod(bytesReceived, recv, clientSocket);
            listenerSocket.Close();
            this.Close();
        }

        private int NewMethod(int bytesReceived, byte[] recv, Socket clientSocket)
        {

            while (clientSocket.Connected)
            {
                
                string text = "";
                // Kiểm tra trạng thái kết nối trước khi nhận dữ liệu
                if (clientSocket.Poll(0, SelectMode.SelectRead) && clientSocket.Available == 0)
                    break; // Thoát khỏi vòng lặp nếu kết nối bị đóng
                do
                {
                    try
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        text += System.Text.Encoding.UTF8.GetString(recv, 0, bytesReceived);
                    }
                    catch(Exception ex)
                    {
                        break;
                    }
                } while (text[text.Length - 1] != '\n');
                richCommand.AppendText(text);
            }
            return bytesReceived;

        }

    }
}
