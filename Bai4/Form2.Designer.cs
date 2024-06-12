namespace Bai4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cklseat = new System.Windows.Forms.CheckedListBox();
            this.gbescape = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.pbposter = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbroom = new System.Windows.Forms.ComboBox();
            this.cbphim = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbstatic = new System.Windows.Forms.GroupBox();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbescape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbposter)).BeginInit();
            this.gbstatic.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIVERSE CINEMA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbescape);
            this.groupBox1.Controls.Add(this.gbstatic);
            this.groupBox1.Controls.Add(this.cklseat);
            this.groupBox1.Controls.Add(this.pbposter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbroom);
            this.groupBox1.Controls.Add(this.cbphim);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt vé";
            // 
            // cklseat
            // 
            this.cklseat.CheckOnClick = true;
            this.cklseat.FormattingEnabled = true;
            this.cklseat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cklseat.Location = new System.Drawing.Point(360, 85);
            this.cklseat.Margin = new System.Windows.Forms.Padding(2);
            this.cklseat.MultiColumn = true;
            this.cklseat.Name = "cklseat";
            this.cklseat.ScrollAlwaysVisible = true;
            this.cklseat.Size = new System.Drawing.Size(335, 180);
            this.cklseat.TabIndex = 19;
            this.cklseat.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklseat_ItemCheck);
            // 
            // gbescape
            // 
            this.gbescape.Controls.Add(this.button5);
            this.gbescape.Controls.Add(this.btclose);
            this.gbescape.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbescape.Location = new System.Drawing.Point(61, 240);
            this.gbescape.Name = "gbescape";
            this.gbescape.Size = new System.Drawing.Size(634, 52);
            this.gbescape.TabIndex = 12;
            this.gbescape.TabStop = false;
            this.gbescape.Text = "Kết thúc";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Đặt thêm vé";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(91, 20);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(88, 23);
            this.btclose.TabIndex = 0;
            this.btclose.Text = "Thoát";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.button4_Click);
            // 
            // pbposter
            // 
            this.pbposter.Location = new System.Drawing.Point(78, 158);
            this.pbposter.Name = "pbposter";
            this.pbposter.Size = new System.Drawing.Size(256, 124);
            this.pbposter.TabIndex = 11;
            this.pbposter.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Poster";
            // 
            // cbroom
            // 
            this.cbroom.FormattingEnabled = true;
            this.cbroom.Location = new System.Drawing.Point(78, 116);
            this.cbroom.Name = "cbroom";
            this.cbroom.Size = new System.Drawing.Size(256, 27);
            this.cbroom.TabIndex = 9;
            this.cbroom.SelectionChangeCommitted += new System.EventHandler(this.cbroom_SelectionChangeCommitted);
            // 
            // cbphim
            // 
            this.cbphim.FormattingEnabled = true;
            this.cbphim.Location = new System.Drawing.Point(78, 74);
            this.cbphim.Name = "cbphim";
            this.cbphim.Size = new System.Drawing.Size(256, 27);
            this.cbphim.TabIndex = 8;
            this.cbphim.SelectedIndexChanged += new System.EventHandler(this.cbphim_SelectedIndexChanged);
            this.cbphim.SelectionChangeCommitted += new System.EventHandler(this.cbphim_SelectionChangeCommitted);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(442, 27);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(254, 27);
            this.txtemail.TabIndex = 7;
            this.txtemail.Text = "kaigiabao7944@gmail.com";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(77, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(257, 27);
            this.txtname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chỗ ngồi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // gbstatic
            // 
            this.gbstatic.Controls.Add(this.btrefresh);
            this.gbstatic.Controls.Add(this.btdelete);
            this.gbstatic.Controls.Add(this.btadd);
            this.gbstatic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbstatic.Location = new System.Drawing.Point(65, 236);
            this.gbstatic.Name = "gbstatic";
            this.gbstatic.Size = new System.Drawing.Size(640, 56);
            this.gbstatic.TabIndex = 2;
            this.gbstatic.TabStop = false;
            this.gbstatic.Text = "Sự kiện";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(447, 20);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 2;
            this.btrefresh.Text = "refresh ";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.button3_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(252, 20);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(84, 23);
            this.btdelete.TabIndex = 1;
            this.btdelete.Text = "Xóa";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btadd
            // 
            this.btadd.Enabled = false;
            this.btadd.Location = new System.Drawing.Point(82, 20);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "Xác nhận";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbescape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbposter)).EndInit();
            this.gbstatic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbposter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbroom;
        private System.Windows.Forms.ComboBox cbphim;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbstatic;
        private System.Windows.Forms.GroupBox gbescape;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.CheckedListBox cklseat;
    }
}