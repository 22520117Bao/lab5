namespace Bai5
{
    partial class SendMail
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
            this.btsend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btsend
            // 
            this.btsend.Location = new System.Drawing.Point(7, 6);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(75, 56);
            this.btsend.TabIndex = 17;
            this.btsend.Text = "Send";
            this.btsend.UseVisualStyleBackColor = true;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "From";
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(60, 110);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(625, 172);
            this.txtinfo.TabIndex = 12;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(60, 84);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(625, 20);
            this.txtsubject.TabIndex = 11;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(143, 34);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(348, 20);
            this.txtto.TabIndex = 10;
            this.txtto.Text = "kaigiabao7944@gmail.com";
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(143, 5);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(348, 20);
            this.txtfrom.TabIndex = 9;
            this.txtfrom.Text = "kaigiabao1009@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(146, 61);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(345, 20);
            this.txtpass.TabIndex = 19;
            this.txtpass.Text = "spet fooy vzqb ddes";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 291);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Name = "SendMail";
            this.Text = "SendMail";
            this.Load += new System.EventHandler(this.SendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpass;
    }
}