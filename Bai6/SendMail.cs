using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void btsend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtfrom.Text) || string.IsNullOrEmpty(txtinfo.Text) || string.IsNullOrEmpty(txtsubject.Text) || string.IsNullOrEmpty(txtto.Text))
            {
                MessageBox.Show("Điền hết vào chỗ trống", "Warning", MessageBoxButtons.OK);
            }
            string from, to, pass, content, sub;
            from = txtfrom.Text.Trim();
            to = txtto.Text.Trim();
            pass = txtpass.Text.Trim();
            content = txtinfo.Text.Trim();
            sub = txtsubject.Text.Trim();
            MailMessage smtp = new MailMessage();
            smtp.To.Add(to);
            smtp.From = new MailAddress(from);
            smtp.Subject = sub;
            smtp.Body = content;
            if (string.IsNullOrEmpty(txtfile.Text))
            {
                MessageBox.Show("Cần lây file ra ", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                Attachment attacht = new Attachment(txtfile.Text);// tệp tin đính kèm 
                smtp.Attachments.Add(attacht);
            }
            System.Net.Mail.SmtpClient mail = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            mail.EnableSsl = true;
            mail.Port = 587;
            mail.DeliveryMethod = SmtpDeliveryMethod.Network;
            mail.Credentials = new NetworkCredential(from, pass);
            try
            {
                mail.Send(smtp);
                MessageBox.Show("Send success");
                txtsubject.Clear();
                txtfile.Clear();
                txtinfo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtfile.Text = openFileDialog.FileName;
            }
        }
    }
}
