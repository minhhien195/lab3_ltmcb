using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SOCKET
{
    public partial class Lab3_Bai4 : Form
    {
        public Lab3_Bai4()
        {
            InitializeComponent();
        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            Chat_Server chat_Server = new Chat_Server();
            chat_Server.Show();
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            Chat_Client chat_Client = new Chat_Client();
            chat_Client.Show();
        }
    }
}
