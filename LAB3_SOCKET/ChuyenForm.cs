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
    public partial class ChuyenForm : Form
    {
        public ChuyenForm()
        {
            InitializeComponent();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Lab3_Bai4 lab3_Bai4 = new Lab3_Bai4();
            lab3_Bai4.Show();
        }


        private void btnBai1_UDPClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1_UDPClient bai1_Client = new Bai1_UDPClient();
            bai1_Client.Show();
            Bai1_UDPServer bai1_Server = new Bai1_UDPServer();
            bai1_Server.Show();
            bai1_Client = null;
            bai1_Server = null;
            this.Show();
        }

        private void btnBai1_UDPServer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1_UDPServer bai1_Server = new Bai1_UDPServer();
            bai1_Server.Show();
            Bai1_UDPClient bai1_Client = new Bai1_UDPClient();
            bai1_Client.Show();
            bai1_Server = null;
            bai1_Client = null;
            this.Show();
        }

        private void btnBai2_TCP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2_TCP bai2_TCP = new Bai2_TCP();
            bai2_TCP.Show();
            bai2_TCP = null;
            this.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Lab3_Bai03 lab3_Bai03 = new Lab3_Bai03();
            lab3_Bai03.Show();
        }
    }
}
