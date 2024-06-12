using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
namespace Bai4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            gbescape.Visible = false;
            try
            {
                Phims = DeserializeJson("input5.txt");
                foreach (var Phim in Phims)
                {
                    cbphim.Items.Add(Phim.TenPhim);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<Phim> Phims = new List<Phim>();
        static Phim SelectedPhim = new Phim();
        static Phim.CPhong SelectedPhong = new Phim.CPhong();
        private List<Phim> DeserializeJson(string Filepath)
        {
            string json = File.ReadAllText(Filepath);
            List<Phim> Phims = JsonSerializer.Deserialize<List<Phim>>(json);
            return Phims;
        }
        private void SerializeJson(object obj, string Filepath)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(Filepath, json);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            long tong = 0; // tinh tổng tiền từ checked seats
            long cost = SelectedPhim.GiaVe;
            foreach (string c in cklseat.CheckedItems)
            {
                if (new[] { "A1", "A5", "B1", "B5", "C1", "C5" }.Contains(c))
                {
                    tong += cost * 1 / 4;
                }
                else if (new[] { "A2", "A3", "A4", "C2", "C3", "C4" }.Contains(c))
                {
                    tong += cost * 1;
                }
                else
                {
                    tong += cost * 2;
                }
            }
            string s = "Ho va ten: " + txtname.Text;
            s += System.Environment.NewLine + "Các vé đã chọn: ";
            foreach (string c in cklseat.CheckedItems)
                s += c + " ";
            s += System.Environment.NewLine;
            s += "Phòng chiếu: " + cbroom.Text;
            s += System.Environment.NewLine;
            s += "Số tiền phải trả: " + tong.ToString();


            if (MessageBox.Show(s, "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) // thông báo lần cuối chắc chắn hay ko ? 
            {
                return;
            }
            else
            {
                MessageBox.Show("Bạn đã đặt vé thành công.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelectedPhim.TongTien += tong;
                HashSet<string> temp = SelectedPhong.suat.ToHashSet();
                foreach (string c in cklseat.CheckedItems)
                {
                    temp.Remove(c);
                }
                SelectedPhong.suat = temp.ToArray();
                foreach (var c in SelectedPhim.Phong)
                {
                    if (c.TenPhong == SelectedPhong.TenPhong)
                    {
                        SelectedPhim.Phong.Remove(c);
                        SelectedPhim.Phong.Add(SelectedPhong);
                        break;
                    }
                }
                foreach (var c in Phims)
                {
                    if (SelectedPhim.TenPhim == c.TenPhim)
                    {
                        Phims.Remove(c);
                        Phims.Add(SelectedPhim);
                        break;
                    }
                }
                SerializeJson(Phims, "output5.txt");

                SendConfirmationEmail(tong);
              
                txtname.Text = "";
                cbphim.Text = "";
                cbroom.Text = "";
                cbroom.Enabled = false;
                SelectedPhim = null;
                SelectedPhong = new Phim.CPhong();
                cbroom.Items.Clear();
                cklseat.Items.Clear();
                gbescape.Visible = true;
                gbstatic.Visible = false;
            }
        }
        private string ConvertImageToBase64(string imagePath)
        {
            byte[] imageArray = File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageArray);
        }

        private void SendConfirmationEmail(long totalCost)
        {
            string base64image = ConvertImageToBase64($@"{SelectedPhim.ImageUrl}"); // Chuyển đổi hình ảnh thành chuỗi base64
            string emailContent = $@"
                    <html>
            <head>
                <style>
                    body {{
                        background-image: url('data:image/jpg;base64,{base64image}');
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
                    <h2>Xin chào bạn {txtname.Text},</h2>
                    <p>Bộ phim mà bạn đặt là <strong>{SelectedPhim.TenPhim}</strong> tại phòng chiếu <strong>{cbroom.Text}</strong>.</p>
                    <p>Để biết thêm chi tiết bạn cần xem thông tin dưới đây :</p>
                    <ul>
                        <li>Số ghế đã đặt: {string.Join(", ", cklseat.CheckedItems.Cast<string>())}</li>
                        <li>Tổng tiền phải trả: {totalCost.ToString("N0")} VND</li>
                    </ul>
                    <p>Chân thành cảm ơn bạn đã đặt vé xem phim nơi chúng tôi!</p>
                    <p>Chúc bạn có một buổi xem phim vui vẻ,</p>
                    <P>Chân trọng</p>
                    <p>UNIVERSE CINEMA</p>
                </div>
            </body>
            </html>";

            string fromAddress = "kaigiabao1009@gmail.com";
            string toAddress = txtemail.Text;
            string subject = "Booking Info";
            string body = emailContent;

            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true; // Kích hoạt SSL

                    string email = "kaigiabao1009@gmail.com";
                    string password = "spet fooy vzqb ddes";

                    client.Credentials = new NetworkCredential(email, password); // Đặt thông tin xác thực

                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress(fromAddress);
                        mailMessage.To.Add(toAddress);
                        mailMessage.Subject = subject;
                        mailMessage.Body = body;
                        mailMessage.IsBodyHtml = true; // Đặt nội dung email là HTML

                        Attachment attachment = new Attachment($@"{SelectedPhim.ImageUrl}"); // Đính kèm hình ảnh
                        attachment.ContentDisposition.Inline = true;
                        attachment.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                        mailMessage.Attachments.Add(attachment);

                        client.Send(mailMessage); // Gửi email
                    }
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"SMTP error: {ex.StatusCode} - {ex.Message}"); // Hiển thị lỗi SMTP
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}"); // Hiển thị lỗi chung
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn những thông tin trên không?","Waring",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                txtname.Clear();
                cbphim.Text = "";
                cbroom.Text = "";
                cklseat.Items.Clear();
                cbroom.Enabled = false;
                pbposter.Image = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát không", "Waring", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gbescape.Visible = false;
            gbstatic.Visible = true;
            txtname.Clear();
            cbphim.Text = "";
            cbroom.Text = "";
            cklseat.Items.Clear();
            cbroom.Enabled = false;
            pbposter.Image = null;

        }

        private void cbphim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbphim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbroom.Items.Clear();
            if (cbphim.SelectedItem != null)
            {
                foreach (Phim Phim in Phims)
                {
                    if (Phim.TenPhim == cbphim.SelectedItem.ToString())
                    {
                        //MessageBox.Show("1");
                        SelectedPhim = Phim;
                        break;
                    }
                }

                if (SelectedPhim != null && SelectedPhim.Phong != null)
                {
                    //MessageBox.Show("2"); 
                    foreach (Phim.CPhong phong in SelectedPhim.Phong)
                    {
                        cbroom.Items.Add(phong.TenPhong);
                    }
                }
                cbroom.Enabled = true;
                string img = SelectedPhim.ImageUrl;
                pbposter.BackgroundImageLayout = ImageLayout.Stretch;
                pbposter.SizeMode = PictureBoxSizeMode.StretchImage;
                pbposter.ImageLocation = img;
            }
        }

        private void cbroom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cklseat.Items.Clear();
            if (cbroom.SelectedItem != null && SelectedPhim != null && SelectedPhim.Phong != null)
            {
                //MessageBox.Show("3"); ;
                foreach (Phim.CPhong c in SelectedPhim.Phong)
                {
                    if (c.TenPhong == cbroom.SelectedItem.ToString())
                    {
                        //MessageBox.Show("4"); ;
                        SelectedPhong = c;
                        break;
                    }
                }

                if (SelectedPhong.suat != null)
                {
                    cklseat.Items.AddRange(SelectedPhong.suat);
                }
            }
        }

        private void cklseat_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cklseat.CheckedItems.Count == 1)
            {
                if (e.NewValue == CheckState.Unchecked)
                    btadd.Enabled = false;
            }
            else
                btadd.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với UNIVERSE Cinema", "!!", MessageBoxButtons.OK);
            MessageBox.Show("Mời bạn nhập đầy đủ thông tin để hoàn thành đăng kí vé", "INFO", MessageBoxButtons.OK);
        }
    }
}
