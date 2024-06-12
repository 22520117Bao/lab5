namespace Bai4
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
            this.btcreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btdatve = new System.Windows.Forms.Button();
            this.btconsume = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtposter = new System.Windows.Forms.TextBox();
            this.txtremain = new System.Windows.Forms.TextBox();
            this.ckP1 = new System.Windows.Forms.CheckBox();
            this.ckP2 = new System.Windows.Forms.CheckBox();
            this.ckP3 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcreate
            // 
            this.btcreate.Location = new System.Drawing.Point(262, 16);
            this.btcreate.Name = "btcreate";
            this.btcreate.Size = new System.Drawing.Size(110, 36);
            this.btcreate.TabIndex = 0;
            this.btcreate.Text = "Create";
            this.btcreate.UseVisualStyleBackColor = true;
            this.btcreate.Click += new System.EventHandler(this.btcreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nếu chưa có phim hãy tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = " Số lượng phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phòng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá vé chuẩn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Poster bộ phim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Remain";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bảng thông kê";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(446, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 292);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nếu bạn muốn đặt vé thì hãy ấn nút này ";
            // 
            // btdatve
            // 
            this.btdatve.Location = new System.Drawing.Point(280, 319);
            this.btdatve.Name = "btdatve";
            this.btdatve.Size = new System.Drawing.Size(119, 27);
            this.btdatve.TabIndex = 10;
            this.btdatve.Text = "Đặt vé";
            this.btdatve.UseVisualStyleBackColor = true;
            this.btdatve.Click += new System.EventHandler(this.btdatve_Click);
            // 
            // btconsume
            // 
            this.btconsume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconsume.Location = new System.Drawing.Point(446, 3);
            this.btconsume.Name = "btconsume";
            this.btconsume.Size = new System.Drawing.Size(313, 27);
            this.btconsume.TabIndex = 11;
            this.btconsume.Text = "Thống kê";
            this.btconsume.UseVisualStyleBackColor = true;
            this.btconsume.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(446, 351);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(313, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(126, 58);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(295, 22);
            this.txtSL.TabIndex = 13;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(130, 157);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(295, 22);
            this.txtprice.TabIndex = 14;
            // 
            // txtposter
            // 
            this.txtposter.Location = new System.Drawing.Point(130, 198);
            this.txtposter.Name = "txtposter";
            this.txtposter.ReadOnly = true;
            this.txtposter.Size = new System.Drawing.Size(221, 22);
            this.txtposter.TabIndex = 15;
            // 
            // txtremain
            // 
            this.txtremain.Location = new System.Drawing.Point(351, 246);
            this.txtremain.Name = "txtremain";
            this.txtremain.Size = new System.Drawing.Size(70, 22);
            this.txtremain.TabIndex = 16;
            // 
            // ckP1
            // 
            this.ckP1.AutoSize = true;
            this.ckP1.Location = new System.Drawing.Point(126, 123);
            this.ckP1.Name = "ckP1";
            this.ckP1.Size = new System.Drawing.Size(70, 19);
            this.ckP1.TabIndex = 17;
            this.ckP1.Text = "Phòng 1";
            this.ckP1.UseVisualStyleBackColor = true;
            // 
            // ckP2
            // 
            this.ckP2.AutoSize = true;
            this.ckP2.Location = new System.Drawing.Point(225, 123);
            this.ckP2.Name = "ckP2";
            this.ckP2.Size = new System.Drawing.Size(70, 19);
            this.ckP2.TabIndex = 18;
            this.ckP2.Text = "Phòng 2";
            this.ckP2.UseVisualStyleBackColor = true;
            // 
            // ckP3
            // 
            this.ckP3.AutoSize = true;
            this.ckP3.Location = new System.Drawing.Point(329, 123);
            this.ckP3.Name = "ckP3";
            this.ckP3.Size = new System.Drawing.Size(70, 19);
            this.ckP3.TabIndex = 19;
            this.ckP3.Text = "Phòng 3";
            this.ckP3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tổng";
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(88, 245);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(72, 22);
            this.txtsum.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Thêm phim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(126, 86);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(295, 22);
            this.txtname.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tên phim";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ckP3);
            this.Controls.Add(this.ckP2);
            this.Controls.Add(this.ckP1);
            this.Controls.Add(this.txtremain);
            this.Controls.Add(this.txtposter);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btconsume);
            this.Controls.Add(this.btdatve);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcreate);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Vé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btdatve;
        private System.Windows.Forms.Button btconsume;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtposter;
        private System.Windows.Forms.TextBox txtremain;
        private System.Windows.Forms.CheckBox ckP1;
        private System.Windows.Forms.CheckBox ckP2;
        private System.Windows.Forms.CheckBox ckP3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}

