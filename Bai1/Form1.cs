using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btsend_Click(object sender, EventArgs e)
        {
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

            System.Net.Mail.SmtpClient mail = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            mail.EnableSsl = true;
            mail.Port = 587;
            mail.DeliveryMethod = SmtpDeliveryMethod.Network;
            mail.Credentials = new NetworkCredential(from, pass);
            try
            {
                mail.Send(smtp);
                MessageBox.Show("Send success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"error");
            }
        }
    }
}
