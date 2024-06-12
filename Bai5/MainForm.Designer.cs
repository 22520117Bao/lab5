namespace Bai5
{
    partial class MainForm
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
            this.txtpage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.btpre = new System.Windows.Forms.Button();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.lbfood = new System.Windows.Forms.ListBox();
            this.btmyfood = new System.Windows.Forms.Button();
            this.btallfood = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btrandomfood = new System.Windows.Forms.Button();
            this.btaddfood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btgetfood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(374, 358);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(85, 20);
            this.txtpage.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Page size";
            // 
            // btnext
            // 
            this.btnext.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.Location = new System.Drawing.Point(201, 355);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(75, 23);
            this.btnext.TabIndex = 22;
            this.btnext.Text = ">";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btpre
            // 
            this.btpre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpre.Location = new System.Drawing.Point(33, 355);
            this.btpre.Name = "btpre";
            this.btpre.Size = new System.Drawing.Size(75, 23);
            this.btpre.TabIndex = 21;
            this.btpre.Text = "<";
            this.btpre.UseVisualStyleBackColor = true;
            this.btpre.Click += new System.EventHandler(this.btpre_Click);
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(135, 358);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(47, 20);
            this.txtcount.TabIndex = 20;
            this.txtcount.Text = "1";
            this.txtcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbfood
            // 
            this.lbfood.FormattingEnabled = true;
            this.lbfood.Location = new System.Drawing.Point(9, 36);
            this.lbfood.Name = "lbfood";
            this.lbfood.ScrollAlwaysVisible = true;
            this.lbfood.Size = new System.Drawing.Size(499, 316);
            this.lbfood.TabIndex = 19;
            // 
            // btmyfood
            // 
            this.btmyfood.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmyfood.Location = new System.Drawing.Point(514, 122);
            this.btmyfood.Name = "btmyfood";
            this.btmyfood.Size = new System.Drawing.Size(128, 27);
            this.btmyfood.TabIndex = 18;
            this.btmyfood.Text = "My food";
            this.btmyfood.UseVisualStyleBackColor = true;
            this.btmyfood.Click += new System.EventHandler(this.btmyfood_Click);
            // 
            // btallfood
            // 
            this.btallfood.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btallfood.Location = new System.Drawing.Point(514, 62);
            this.btallfood.Name = "btallfood";
            this.btallfood.Size = new System.Drawing.Size(128, 27);
            this.btallfood.TabIndex = 17;
            this.btallfood.Text = "All food";
            this.btallfood.UseVisualStyleBackColor = true;
            this.btallfood.Click += new System.EventHandler(this.btallfood_Click);
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Location = new System.Drawing.Point(514, 4);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(128, 29);
            this.btdelete.TabIndex = 16;
            this.btdelete.Text = "Xóa món ăn";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btrandomfood
            // 
            this.btrandomfood.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrandomfood.Location = new System.Drawing.Point(222, 2);
            this.btrandomfood.Name = "btrandomfood";
            this.btrandomfood.Size = new System.Drawing.Size(131, 30);
            this.btrandomfood.TabIndex = 15;
            this.btrandomfood.Text = "Ăn gì giờ";
            this.btrandomfood.UseVisualStyleBackColor = true;
            this.btrandomfood.Click += new System.EventHandler(this.btrandomfood_Click);
            // 
            // btaddfood
            // 
            this.btaddfood.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddfood.Location = new System.Drawing.Point(381, 2);
            this.btaddfood.Name = "btaddfood";
            this.btaddfood.Size = new System.Drawing.Size(128, 30);
            this.btaddfood.TabIndex = 14;
            this.btaddfood.Text = "Thêm món ăn";
            this.btaddfood.UseVisualStyleBackColor = true;
            this.btaddfood.Click += new System.EventHandler(this.btaddfood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "HÔM NAY ĂN GÌ GIỜ";
            // 
            // btgetfood
            // 
            this.btgetfood.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgetfood.Location = new System.Drawing.Point(514, 174);
            this.btgetfood.Name = "btgetfood";
            this.btgetfood.Size = new System.Drawing.Size(128, 27);
            this.btgetfood.TabIndex = 25;
            this.btgetfood.Text = "Get Food";
            this.btgetfood.UseVisualStyleBackColor = true;
            this.btgetfood.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 394);
            this.Controls.Add(this.btgetfood);
            this.Controls.Add(this.txtpage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btpre);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.lbfood);
            this.Controls.Add(this.btmyfood);
            this.Controls.Add(this.btallfood);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btrandomfood);
            this.Controls.Add(this.btaddfood);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btpre;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.ListBox lbfood;
        private System.Windows.Forms.Button btmyfood;
        private System.Windows.Forms.Button btallfood;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btrandomfood;
        private System.Windows.Forms.Button btaddfood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btgetfood;
    }
}