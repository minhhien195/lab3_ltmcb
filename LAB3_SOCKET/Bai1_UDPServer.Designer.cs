namespace LAB3_SOCKET
{
    partial class Bai1_UDPServer
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
            this.btnListen = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbRcvMess = new System.Windows.Forms.Label();
            this.richtxtRevMess = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(607, 65);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(103, 53);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(172, 76);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(157, 30);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8000";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(95, 79);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(47, 25);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port";
            // 
            // lbRcvMess
            // 
            this.lbRcvMess.AutoSize = true;
            this.lbRcvMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRcvMess.Location = new System.Drawing.Point(95, 172);
            this.lbRcvMess.Name = "lbRcvMess";
            this.lbRcvMess.Size = new System.Drawing.Size(179, 25);
            this.lbRcvMess.TabIndex = 3;
            this.lbRcvMess.Text = "Received Message";
            // 
            // richtxtRevMess
            // 
            this.richtxtRevMess.Enabled = false;
            this.richtxtRevMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtRevMess.Location = new System.Drawing.Point(100, 219);
            this.richtxtRevMess.Name = "richtxtRevMess";
            this.richtxtRevMess.Size = new System.Drawing.Size(610, 207);
            this.richtxtRevMess.TabIndex = 4;
            this.richtxtRevMess.Text = "";
            // 
            // Bai1_UDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richtxtRevMess);
            this.Controls.Add(this.lbRcvMess);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnListen);
            this.Name = "Bai1_UDPServer";
            this.Text = "Bai1_UDPServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbRcvMess;
        private System.Windows.Forms.RichTextBox richtxtRevMess;
    }
}