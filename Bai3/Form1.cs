using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MimeKit;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();
            string password = txtpass.Text.Trim();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Nhap day du vao o trong", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                EmailLoading(email, password);
            }
        }
        private async void EmailLoading(string email, string password)
        {            
                try
                {
                    using (var client = new Pop3Client())
                    {
                        // Bỏ qua kiểm tra chứng chỉ
                        client.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                        await client.ConnectAsync("pop.gmail.com", 995, true);
                        await client.AuthenticateAsync(email, password);
                    int totalEmails = client.Count;
                    txttotal.Text = totalEmails.ToString(); // Hiển thị tổng số email
                    // Lấy số lượng email cần đọc từ textbox
                    int emailCountToFetch = int.Parse(txtrecent.Text.Trim());
                    // Kiểm tra nếu số lượng cần đọc lớn hơn tổng số email thì lấy tổng số email
                    if (emailCountToFetch > totalEmails)
                    {
                        emailCountToFetch = totalEmails;
                    }
                    List<MimeMessage> recentEmails = new List<MimeMessage>();
                    listViewEmails.Items.Clear();
                        for (int i = totalEmails - emailCountToFetch; i < totalEmails ; i++)
                        {
                            var message = await client.GetMessageAsync(i);
                            recentEmails.Add(message);
                        }
                    recentEmails.Reverse();
                    foreach (var message in recentEmails)
                    {
                        var listViewItem = new ListViewItem(new[] {
                            message.Subject,
                            message.From.ToString(),
                            message.Date.DateTime.ToString()
                        });

                        listViewEmails.Items.Add(listViewItem);
                    }
                    await client.DisconnectAsync(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        private void Form1_Load(object sender, EventArgs e)
        {
            listViewEmails.View = View.Details;
            listViewEmails.Columns.Add("Subject", 200);
            listViewEmails.Columns.Add("From", 200);
            listViewEmails.Columns.Add("Date", 150);            
        }
    }
}
