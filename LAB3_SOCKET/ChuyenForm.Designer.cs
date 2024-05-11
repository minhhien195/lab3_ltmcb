namespace LAB3_SOCKET
{
    partial class ChuyenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBai1_UDPClient = new System.Windows.Forms.Button();
            this.btnBai1_UDPServer = new System.Windows.Forms.Button();
            this.btnBai2_TCP = new System.Windows.Forms.Button();
            this.btnBai4 = new System.Windows.Forms.Button();
            this.btnBai3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai1_UDPClient
            // 
            this.btnBai1_UDPClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai1_UDPClient.Location = new System.Drawing.Point(106, 36);
            this.btnBai1_UDPClient.Name = "btnBai1_UDPClient";
            this.btnBai1_UDPClient.Size = new System.Drawing.Size(218, 95);
            this.btnBai1_UDPClient.TabIndex = 0;
            this.btnBai1_UDPClient.Text = "Bài 1_UDPClient";
            this.btnBai1_UDPClient.UseVisualStyleBackColor = true;
            this.btnBai1_UDPClient.Click += new System.EventHandler(this.btnBai1_UDPClient_Click);
            // 
            // btnBai1_UDPServer
            // 
            this.btnBai1_UDPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai1_UDPServer.Location = new System.Drawing.Point(371, 36);
            this.btnBai1_UDPServer.Name = "btnBai1_UDPServer";
            this.btnBai1_UDPServer.Size = new System.Drawing.Size(223, 95);
            this.btnBai1_UDPServer.TabIndex = 1;
            this.btnBai1_UDPServer.Text = "Bài 1_UDPServer";
            this.btnBai1_UDPServer.UseVisualStyleBackColor = true;
            this.btnBai1_UDPServer.Click += new System.EventHandler(this.btnBai1_UDPServer_Click);
            // 
            // btnBai2_TCP
            // 
            this.btnBai2_TCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai2_TCP.Location = new System.Drawing.Point(106, 170);
            this.btnBai2_TCP.Name = "btnBai2_TCP";
            this.btnBai2_TCP.Size = new System.Drawing.Size(148, 95);
            this.btnBai2_TCP.TabIndex = 2;
            this.btnBai2_TCP.Text = "Bài 2_TCP";
            this.btnBai2_TCP.UseVisualStyleBackColor = true;
            this.btnBai2_TCP.Click += new System.EventHandler(this.btnBai2_TCP_Click);
            // 
            // btnBai4
            // 
            this.btnBai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai4.Location = new System.Drawing.Point(371, 184);
            this.btnBai4.Name = "btnBai4";
            this.btnBai4.Size = new System.Drawing.Size(148, 90);
            this.btnBai4.TabIndex = 3;
            this.btnBai4.Text = "Bài 4";
            this.btnBai4.UseVisualStyleBackColor = true;
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);
            // 
            // btnBai3
            // 
            this.btnBai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai3.Location = new System.Drawing.Point(106, 298);
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new System.Drawing.Size(148, 90);
            this.btnBai3.TabIndex = 4;
            this.btnBai3.Text = "Bài 3";
            this.btnBai3.UseVisualStyleBackColor = true;
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);
            // 
            // ChuyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBai3);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.btnBai2_TCP);
            this.Controls.Add(this.btnBai1_UDPServer);
            this.Controls.Add(this.btnBai1_UDPClient);
            this.Name = "ChuyenForm";
            this.Text = "Chuyển Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBai1_UDPClient;
        private System.Windows.Forms.Button btnBai1_UDPServer;
        private System.Windows.Forms.Button btnBai2_TCP;
        private System.Windows.Forms.Button btnBai4;
        private System.Windows.Forms.Button btnBai3;
    }
}

