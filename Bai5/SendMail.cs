using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MimeKit;
using MailKit.Security;
using System.IO;
using System.Net.Mail;

namespace Bai5
{
    public partial class SendMail : Form
    {

        private List<string> entries = new List<string>();
        public string chuoi = "";
        public SendMail(string a, string s, List<string> ent)
        {
            InitializeComponent();
            txtsubject.Text = s;
            chuoi = a;
            txtinfo.Text = chuoi;
            entries = ent;
           
        }
        private string ConvertImageToBase64(string imagePath)
        {
            byte[] imageArray = File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageArray);
        }


        private void btsend_Click(object sender, EventArgs e)
        {
            string from = "";
            string to = "";
            string pass = "";
            string content = "";
            string sub = "";
            from = txtfrom.Text.Trim();
            to = txtto.Text.Trim();
            pass = txtpass.Text.Trim();
            content = txtinfo.Text.Trim();
            sub = txtsubject.Text.Trim();
            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("", from));
            mimeMessage.To.Add(new MailboxAddress("", to));
            mimeMessage.Subject = sub;
            var bodyBuilder = new BodyBuilder();
            //string emailContent = "";
            foreach (var entry in entries)
            {
                string tenmonan, gia, adr, in4, people, imgurl;
                string[] parts = entry.Split(',');
                if (parts.Length == 6)
                {
                    tenmonan = parts[0];
                    gia = parts[1];
                    adr = parts[2];
                    in4 = parts[3];
                    people = parts[4];
                    imgurl = parts[5].Trim();
                    string base64image = ConvertImageToBase64($@"{imgurl}");
                    bodyBuilder.HtmlBody += $@"
                    <html>
            <head>
                <style>
                    body {{
                        background-image: url('data:image/png;base64,{base64image}');
                        background-size: cover;
                        background-repeat: no-repeat;
                        font-family: Arial, sans-serif;
                        color: black;
                    }}
                    .container {{
                        max-width: 600px;
                        margin: auto;
                        padding: 20px;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <img src=""{base64image}"" alt=""Image"" class='email-image'>
                    <h2>Tên món ăn: {tenmonan},</h2>
                    <p>Dưới đây là chi tiết món bạn chọn:</p>
                    <p>Người đóng góp: {people} </p>
                    <p>Giá món ăn {gia}</p>
                    <p>Mô tả: {in4} </p>
                    <p>Chúc bạn tìm món ăn mình yêu thích!</p>
                    <p>Trân trọng,</p>
                    <p>Quán {adr} </p>
                </div>
            </body>
            </html>";
                }
            
            }
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                try
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate(from, pass);
                    client.Send(mimeMessage);
                    client.Disconnect(true);

                    MessageBox.Show("Send success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void SendMail_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
