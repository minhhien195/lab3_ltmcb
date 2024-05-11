using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace LAB3_SOCKET
{
    public partial class Chat_Client : Form
    {
        private TcpClient tcpClient;
        private NetworkStream ns;
        private byte[] buffer;
        public Chat_Client()
        {
            InitializeComponent();
            buffer = new byte[1_024];
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ns != null && txtMessage.Text != "")
            {
                //4 Dùng phương thức Write để gửi dữ liệu đến Server
                Byte[] data = Encoding.UTF8.GetBytes($"{txtName.Text}: {txtMessage.Text}\r\n");
                ns.Write(data, 0, data.Length);
                txtMessage.Text = "";
            }
            else if (txtMessage.Text == "" && ns != null)
            {
                MessageBox.Show("Bạn cần nhập dữ liệu trước khi gửi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ns == null)
            {
                MessageBox.Show("Bạn cần kết nối trước khi gửi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ReceiveDataFromServer(Socket clientSocket)
        {
            byte[] receiveBuffer = new byte[1024]; // Kích thước buffer nhận dữ liệu

            while (true)
            {
                try
                {
                    int bytesRead = clientSocket.Receive(receiveBuffer);
                    if (bytesRead > 0)
                    {
                        string receivedData = Encoding.UTF8.GetString(receiveBuffer, 0, bytesRead);
                        DisplayMessage(receivedData); // Hiển thị dữ liệu nhận được
                    }
                    else
                    {
                        // Kết nối bị đóng bởi server
                        break;
                    }
                }
                catch (SocketException ex)
                {
                    this.Close();
                    MessageBox.Show("SocketException: " + ex.Message);
                    break;
                }
                catch (ObjectDisposedException ex)
                {
                    // Xử lý ngoại lệ ObjectDisposedException
                    MessageBox.Show("ObjectDisposedException: " + ex.Message);
                    break;
                }
            }
        }

        private void DisplayMessage(string message)
        {
            if (rtbMessage.InvokeRequired)
            {
                this.Invoke(new Action<string>(DisplayMessage), new object[] { message });
            }
            else
            {
                rtbMessage.AppendText(message);
            }
        }

        private void Chat_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient != null && tcpClient.Connected)
            {
                // Gửi dữ liệu mang dấu hiệu kết thúc cho Server biết
                Byte[] quit = Encoding.UTF8.GetBytes($"{txtName.Text} quit\n");
                ns.Write(quit, 0, quit.Length);
                ns.Close();
                tcpClient.Close();
                ns = null;
            }
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                //1 Tạo đối tượng TcpClient 
                tcpClient = new TcpClient();
                //2 Kết nối đến Server với 1 địa chỉ Ip và Port xác định 
                IPAddress ipAdress = IPAddress.Parse("127.0.0.1");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAdress, 8080);
                tcpClient.Connect(ipEndPoint);
                //3 Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
                ns = tcpClient.GetStream();

                byte[] nameBytes = Encoding.UTF8.GetBytes(txtName.Text);
                ns.Write(nameBytes, 0, nameBytes.Length);

                btnConnect.Enabled = false;
                Task.Run(() => ReceiveDataFromServer(tcpClient.Client));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void btnDisconnect_Click_1(object sender, EventArgs e)
        {
            if (ns != null && tcpClient != null && tcpClient.Connected) // Kiểm tra chắc rằng đã kết nối
            {
                // Dùng phương thức Write để gửi dữ liệu mang dấu hiệu kết thúc cho Server biết và đóng kết nối
                Byte[] quit = Encoding.UTF8.GetBytes($"{txtName.Text} quit\n");
                ns.Write(quit, 0, quit.Length);
                ns.Close();
                tcpClient.Close();
                ns = null;
                this.Close();
            }
        }
    }
}
