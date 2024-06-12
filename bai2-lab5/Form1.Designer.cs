namespace test1
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
            this.lbtex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.listViewEmails = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrecent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbtex
            // 
            this.lbtex.AutoSize = true;
            this.lbtex.Location = new System.Drawing.Point(4, 14);
            this.lbtex.Name = "lbtex";
            this.lbtex.Size = new System.Drawing.Size(35, 13);
            this.lbtex.TabIndex = 0;
            this.lbtex.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(67, 7);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(371, 20);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = "kaigiabao1009@gmail.com";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(67, 44);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(371, 20);
            this.txtpass.TabIndex = 5;
            this.txtpass.Text = "spet fooy vzqb ddes";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(63, 79);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(51, 20);
            this.txttotal.TabIndex = 6;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(457, 7);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(123, 57);
            this.btlogin.TabIndex = 8;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // listViewEmails
            // 
            this.listViewEmails.HideSelection = false;
            this.listViewEmails.Location = new System.Drawing.Point(12, 105);
            this.listViewEmails.Name = "listViewEmails";
            this.listViewEmails.Size = new System.Drawing.Size(587, 219);
            this.listViewEmails.TabIndex = 9;
            this.listViewEmails.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recent";
            // 
            // txtrecent
            // 
            this.txtrecent.Location = new System.Drawing.Point(231, 79);
            this.txtrecent.Name = "txtrecent";
            this.txtrecent.Size = new System.Drawing.Size(59, 20);
            this.txtrecent.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 336);
            this.Controls.Add(this.txtrecent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewEmails);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.ListView listViewEmails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrecent;
    }
}

