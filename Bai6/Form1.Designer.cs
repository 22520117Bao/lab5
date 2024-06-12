namespace Bai6
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panOperate = new System.Windows.Forms.Panel();
            this.btlogout = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btsendmail = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.panLogin = new System.Windows.Forms.Panel();
            this.btlogin = new System.Windows.Forms.Button();
            this.btload = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtaccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtrecent = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsmtport = new System.Windows.Forms.TextBox();
            this.txtimaport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.txtimap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewEmails = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.panOperate.SuspendLayout();
            this.panLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panOperate);
            this.groupBox1.Controls.Add(this.btstop);
            this.groupBox1.Controls.Add(this.panLogin);
            this.groupBox1.Controls.Add(this.btload);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtaccount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập ";
            // 
            // panOperate
            // 
            this.panOperate.Controls.Add(this.btlogout);
            this.panOperate.Controls.Add(this.btrefresh);
            this.panOperate.Controls.Add(this.btsendmail);
            this.panOperate.Location = new System.Drawing.Point(27, 68);
            this.panOperate.Name = "panOperate";
            this.panOperate.Size = new System.Drawing.Size(344, 35);
            this.panOperate.TabIndex = 3;
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(237, 3);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(75, 23);
            this.btlogout.TabIndex = 2;
            this.btlogout.Text = "Đăng xuất";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(126, 3);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 1;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btsendmail
            // 
            this.btsendmail.Location = new System.Drawing.Point(17, 3);
            this.btsendmail.Name = "btsendmail";
            this.btsendmail.Size = new System.Drawing.Size(75, 23);
            this.btsendmail.TabIndex = 0;
            this.btsendmail.Text = "Gửi mail";
            this.btsendmail.UseVisualStyleBackColor = true;
            this.btsendmail.Click += new System.EventHandler(this.btsendmail_Click);
            // 
            // btstop
            // 
            this.btstop.Location = new System.Drawing.Point(323, 44);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(75, 23);
            this.btstop.TabIndex = 5;
            this.btstop.Text = "Stop";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.btlogin);
            this.panLogin.Location = new System.Drawing.Point(10, 68);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(346, 35);
            this.panLogin.TabIndex = 2;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(147, 3);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "Đăng nhập";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btload
            // 
            this.btload.Location = new System.Drawing.Point(323, 14);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(75, 23);
            this.btload.TabIndex = 4;
            this.btload.Text = "Load";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.btload_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(61, 49);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(238, 20);
            this.txtpass.TabIndex = 3;
            this.txtpass.Text = "spet fooy vzqb ddes";
            // 
            // txtaccount
            // 
            this.txtaccount.Location = new System.Drawing.Point(61, 17);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(238, 20);
            this.txtaccount.TabIndex = 2;
            this.txtaccount.Text = "kaigiabao1009@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtrecent);
            this.groupBox2.Controls.Add(this.txttotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtsmtport);
            this.groupBox2.Controls.Add(this.txtimaport);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtsmtp);
            this.groupBox2.Controls.Add(this.txtimap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng nhập ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "recent";
            // 
            // txtrecent
            // 
            this.txtrecent.Location = new System.Drawing.Point(212, 78);
            this.txtrecent.Name = "txtrecent";
            this.txtrecent.Size = new System.Drawing.Size(70, 20);
            this.txtrecent.TabIndex = 10;
            this.txtrecent.Text = "0";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(51, 78);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(74, 20);
            this.txttotal.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total";
            // 
            // txtsmtport
            // 
            this.txtsmtport.Location = new System.Drawing.Point(252, 52);
            this.txtsmtport.Name = "txtsmtport";
            this.txtsmtport.Size = new System.Drawing.Size(100, 20);
            this.txtsmtport.TabIndex = 7;
            this.txtsmtport.Text = "995";
            // 
            // txtimaport
            // 
            this.txtimaport.Location = new System.Drawing.Point(51, 49);
            this.txtimaport.Name = "txtimaport";
            this.txtimaport.Size = new System.Drawing.Size(100, 20);
            this.txtimaport.TabIndex = 6;
            this.txtimaport.Text = "993";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Port";
            // 
            // txtsmtp
            // 
            this.txtsmtp.Location = new System.Drawing.Point(252, 17);
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(157, 20);
            this.txtsmtp.TabIndex = 3;
            this.txtsmtp.Text = "smtp.gmail.com";
            // 
            // txtimap
            // 
            this.txtimap.Location = new System.Drawing.Point(48, 17);
            this.txtimap.Name = "txtimap";
            this.txtimap.Size = new System.Drawing.Size(155, 20);
            this.txtimap.TabIndex = 2;
            this.txtimap.Text = "imap.gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SMTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IMAP";
            // 
            // listViewEmails
            // 
            this.listViewEmails.HideSelection = false;
            this.listViewEmails.Location = new System.Drawing.Point(10, 127);
            this.listViewEmails.Name = "listViewEmails";
            this.listViewEmails.Size = new System.Drawing.Size(799, 278);
            this.listViewEmails.TabIndex = 2;
            this.listViewEmails.UseCompatibleStateImageBehavior = false;
            this.listViewEmails.SelectedIndexChanged += new System.EventHandler(this.listViewEmails_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 417);
            this.Controls.Add(this.listViewEmails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panOperate.ResumeLayout(false);
            this.panLogin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtaccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsmtport;
        private System.Windows.Forms.TextBox txtimaport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.TextBox txtimap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewEmails;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Panel panOperate;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btsendmail;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.TextBox txtrecent;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

