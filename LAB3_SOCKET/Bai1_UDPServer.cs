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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB3_SOCKET
{
    public partial class Bai1_UDPServer : Form
    {
        public Bai1_UDPServer()
        {
            InitializeComponent();
        }
        private delegate void SafeCallDelegate(string text);
        public void InfoMessage(string message)
        {
           WriteTextSafe(message);
        }
        private void WriteTextSafe(string text)
        {
            if (richtxtRevMess.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                richtxtRevMess.Invoke(d, new object[] { text });
            }
            else
            {
                richtxtRevMess.AppendText(text);
            }
        }
        public void ServerThread()
        {
            int port = Convert.ToInt32(txtPort.Text);
            UdpClient udpClient = new UdpClient(port);
            while(true)
            {
                IPEndPoint RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receivedBytes = udpClient.Receive(ref RemoteEndPoint);
                string ReturnData = Encoding.UTF8.GetString(receivedBytes);
                string mess = RemoteEndPoint.Address.ToString() + ": " + ReturnData + "\n";
                InfoMessage(mess);
            }
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            
            Thread server = new Thread(new ThreadStart(ServerThread));
            server.Start();
        }

    }
}
