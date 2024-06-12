using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;


namespace Bai6
{
    public partial class Form1 : Form
    {
        private string acc, pass;
        private ImapClient imap_Client;
        private MailKit.Net.Smtp.SmtpClient smtp_Client;
        private bool checkload= false;
        public Form1()
        {
            InitializeComponent();
            imap_Client = new ImapClient();
            smtp_Client = new MailKit.Net.Smtp.SmtpClient();
            panOperate.Visible = false;
            btload.Enabled = false;
            btstop.Enabled = false;

        }

        private void btsendmail_Click(object sender, EventArgs e)
        {
            SendMail f1 = new SendMail();
            f1.Show();
        }

        private async void btload_Click(object sender, EventArgs e)
        {
            checkload = false;
            await EmailLoad();
        }

        private async Task EmailLoad()
        {
            try
            { 
                var inbox = imap_Client.Inbox;
                await inbox.OpenAsync(FolderAccess.ReadOnly);
                listViewEmails.Items.Clear();
                int total = inbox.Count;  
                int cfetch = int.Parse(txtrecent.Text);
                if ( cfetch == 0)
                { 
                    total = 0; 
                }
                else
                {
                    total -= cfetch;
                }
                for (int i = total ; i < inbox.Count; i++)
                {
                    if (checkload)
                    {
                        break; // Thoát khỏi vòng lặp nếu checkload là true
                    }
                    MimeMessage message;
                    //xài lock để xác định rằng là chỉ sử dụng ổn định 1 luồng 
                    lock (imap_Client.SyncRoot)
                    {
                        message = imap_Client.Inbox.GetMessage(i);
                    }
                    var item = new ListViewItem(new[] { message.From.ToString(), message.Subject, message.Date.DateTime.ToString() });
                    listViewEmails.Items.Add(item);
                    // Kiểm tra load email thường xuyên bằng cách delay 1s 
                    await Task.Delay(100); 
                    txttotal.Text = i.ToString();
                }
                if (checkload)
                {
                    MessageBox.Show("Loading emails stopped.", "Information", MessageBoxButtons.OK);
                }
                listViewEmails.SelectedIndexChanged += listViewEmails_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading emails: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void listViewEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmails.SelectedItems.Count == 0)
                return;
            var selectedemail = listViewEmails.SelectedItems[0].Index;
            try
            {
                MimeMessage message;
                lock(imap_Client.SyncRoot)
                {
                    message = imap_Client.Inbox.GetMessage(selectedemail);
                }
                string su = message.Subject;
                string dt = message.Date.DateTime.ToString();
                string fr = message.From.ToString();    
                string content = message.TextBody;
                
                ShowEmail f1 = new ShowEmail(content,su,dt,fr);
                f1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Email lỗi không đọc được: {ex.Message}", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            try
            {
                lock(imap_Client.SyncRoot)
                {
                    imap_Client.Disconnect(true);
                }
                MessageBox.Show("Thoát kết nối thành công", "Warning", MessageBoxButtons.OK);
                panOperate.Visible = false;
                panLogin.Visible = true;
                btload.Enabled = false;
                btstop.Enabled = false;
            }
            catch ( Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi ko thấy logout: {ex.Message}  ", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btstop_Click(object sender, EventArgs e)
        {
            checkload = true;
        }

        private void listViewEmails_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewEmails.View = View.Details;
            listViewEmails.Columns.Add("From", 200);
            listViewEmails.Columns.Add("Subject", 200);
            listViewEmails.Columns.Add("Date", 150);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            acc = txtaccount.Text;
            pass = txtpass.Text;
            try
            {
                imap_Client.ServerCertificateValidationCallback = (certSender, certificate, chain, sslPolicyErrors) => true;
                await imap_Client.ConnectAsync(txtimap.Text, 993, true);
                await imap_Client.AuthenticateAsync(acc, pass);
                MessageBox.Show("Logged in successfully!", "Login", MessageBoxButtons.OK);
                panLogin.Visible = false; // Hiển thị bảng điều khiển sau khi đăng nhập
                panOperate.Visible=true;
                btload.Enabled = true;
                btstop.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
