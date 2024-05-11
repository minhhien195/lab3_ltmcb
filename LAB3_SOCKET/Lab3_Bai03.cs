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
    public partial class Lab3_Bai03 : Form
    {
        public Lab3_Bai03()
        {
            InitializeComponent();
        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            Bai3_TCPServer bai3_TCPServer = new Bai3_TCPServer();
            bai3_TCPServer.Show();

        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            Bai3_TCPClient bai3_TCPClient = new Bai3_TCPClient();
            bai3_TCPClient.Show();
        }
    }
}
