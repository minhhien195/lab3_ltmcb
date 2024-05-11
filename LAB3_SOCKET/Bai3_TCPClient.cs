using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace LAB3_SOCKET
{
    public partial class Bai3_TCPClient : Form
    {
        public Bai3_TCPClient()
        {
            InitializeComponent();
        }
        private TcpClient tcpClient;
        private NetworkStream ns;
        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (ns != null && rtbxMessage.Text != "")
            {
                //4 Dùng phương thức Write để gửi dữ liệu đến Server
                Byte[] data = Encoding.ASCII.GetBytes(rtbxMessage.Text + "\n");
                ns.Write(data, 0, data.Length);
                rtbxMessage.Text = "";
            }    
            else if (rtbxMessage.Text == "" && ns != null)
            {
                MessageBox.Show("Bạn cần nhập dữ liệu trước khi gửi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else if (ns == null)
            {
                MessageBox.Show("Bạn cần kết nối trước khi gửi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    

                    
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //1 Tạo đối tượng TcpClient 
            tcpClient = new TcpClient();
            //2 Kết nối đến Server với 1 địa chỉ Ip và Port xác định 
            IPAddress ipAdress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAdress, 8080);
            tcpClient.Connect(ipEndPoint);
            //3 Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
            ns = tcpClient.GetStream();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (ns  != null) // Kiểm tra chắc rằng đã kết nối
            {
                //5 Dùng phương thức Write để gửi dữ liệu mang dấu hiệu kết thúc cho Server biết và đóng kết nối
                Byte[] quit = Encoding.ASCII.GetBytes("quit\n");
                ns.Write(quit, 0, quit.Length);
                ns.Close();
                tcpClient.Close();
                ns = null;
                this.Close();
            }
        }

        private void Bai3_TCPClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ns != null) // Kiểm tra chắc rằng đã kết nối
            {
                //5 Dùng phương thức Write để gửi dữ liệu mang dấu hiệu kết thúc cho Server biết và đóng kết nối
                Byte[] quit = Encoding.ASCII.GetBytes("quit\n");
                ns.Write(quit, 0, quit.Length);
                ns.Close();
                tcpClient.Close();
                ns = null;
                this.Close();
            }
        }
    }
}
