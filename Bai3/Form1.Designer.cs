namespace Bai3
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
            this.txtrecent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewEmails = new System.Windows.Forms.ListView();
            this.btlogin = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtrecent
            // 
            this.txtrecent.Location = new System.Drawing.Point(231, 81);
            this.txtrecent.Name = "txtrecent";
            this.txtrecent.Size = new System.Drawing.Size(59, 20);
            this.txtrecent.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Recent";
            // 
            // listViewEmails
            // 
            this.listViewEmails.HideSelection = false;
            this.listViewEmails.Location = new System.Drawing.Point(12, 107);
            this.listViewEmails.Name = "listViewEmails";
            this.listViewEmails.Size = new System.Drawing.Size(587, 202);
            this.listViewEmails.TabIndex = 19;
            this.listViewEmails.UseCompatibleStateImageBehavior = false;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(444, 9);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(123, 57);
            this.btlogin.TabIndex = 18;
            this.btlogin.Text = "LOGIN";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(63, 81);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(51, 20);
            this.txttotal.TabIndex = 17;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(67, 46);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(371, 20);
            this.txtpass.TabIndex = 16;
            this.txtpass.Text = "ebyh qelc cvpt yllo";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(67, 9);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(371, 20);
            this.txtemail.TabIndex = 15;
            this.txtemail.Text = "kaigiabao1009@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // lbtex
            // 
            this.lbtex.AutoSize = true;
            this.lbtex.Location = new System.Drawing.Point(4, 16);
            this.lbtex.Name = "lbtex";
            this.lbtex.Size = new System.Drawing.Size(35, 13);
            this.lbtex.TabIndex = 12;
            this.lbtex.Text = "Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 329);
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

        private System.Windows.Forms.TextBox txtrecent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewEmails;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtex;
    }
}

