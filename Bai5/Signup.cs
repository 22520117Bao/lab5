using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            btregister_ClickAsync();
        }
        private async Task btregister_ClickAsync()
        {
            // tao cum luu tru cac thong tin nguoi dung
            var info_register = new
            {
                username = txtusername.Text,
                email = txtemail.Text,
                password = txtpass.Text,
                first_name = txtF_name.Text,
                last_name = txtL_name.Text,
                sex = int.Parse(txt_sex.Text),
                birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                language = txtlang.Text,
                phone = txtphone.Text
            };
            // ep info_register thanh kieu json
            string j_info = JsonConvert.SerializeObject(info_register);
            var data = new StringContent(j_info, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {

                var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/user/signup", data);
               
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Success to sign-up");
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"HTTP Status Code: {response.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");
                    this.Close();
                }
                else
                {
                    txtusername.Clear();
                    txtemail.Clear();
                    txtpass.Clear();
                    txtF_name .Clear();
                    txtL_name .Clear();
                    txt_sex .Clear();
                    txtlang .Clear();
                    txtphone .Clear();
                    MessageBox.Show("Fail to sign-up");
                }
            }



        }
    }
}
