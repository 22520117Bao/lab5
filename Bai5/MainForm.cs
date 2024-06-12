using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai5
{
    public partial class MainForm : Form
    {
        public string uname = "";
        public string pa = "";
        public MainForm(string u_name , string pas)
        {
            InitializeComponent();
            uname = u_name;
            pa = pas;
            this.Load += new EventHandler(MainForm_Load);

        }
       

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private List<Food> foodList;
        private int cUserPage = 1;
        private int cAllPage = 1;
        private string cList = "AllFood";
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kaigi\OneDrive\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30");

        private void btrandomfood_Click(object sender, EventArgs e)
        {
            if (foodList != null && foodList.Count > 0)
            {
                var random = new Random();
                var randomFood = foodList[random.Next(foodList.Count)];
                string tenmonan = randomFood.ten_mon_an;
                string gia = randomFood.gia.ToString();
                string mota = randomFood.mo_ta.ToString();
                string diachi = randomFood.dia_chi.ToString();
                string hinhanh = randomFood.hinh_anh.ToString();
                ShowFood f5 = new ShowFood(tenmonan, gia, mota, diachi, hinhanh);
                f5.Show();
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu món ăn.");
            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            Form3_LoadAsync();
        }
        private async Task Form3_LoadAsync()
        {
            await LoadFoodDataAsync();
        }

        private async Task LoadFoodDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new
                    System.Net.Http.Headers.AuthenticationHeaderValue(Tokens.TokenT, Tokens.AccessT);

                var requestBody = new
                {
                    current = 1,
                    pageSize = 5
                };
                txtpage.Text = requestBody.pageSize.ToString();

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/all", content);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();


                    System.IO.File.WriteAllText("food_data.json", jsonResponse);


                    var foodResponse = JsonConvert.DeserializeObject<FoodResponse>(jsonResponse);
                    foodList = foodResponse.Data;


                    lbfood.Items.Clear();
                    foreach (var food in foodList)
                    {
                        lbfood.Items.Add(food);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to load food data.");
                }
            }
        }

        private void btaddfood_Click(object sender, EventArgs e)
        {
            ThemMonAn f1 = new ThemMonAn();
            f1.Show();
        }
        private async Task LoadUserCreatedFoodAsync(int currentUserPage)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(Tokens.TokenT, Tokens.AccessT);
                var requestBody = new
                {
                    current = currentUserPage,
                    pageSize = 5
                };
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/my-dishes", content);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var foodResponse = JsonConvert.DeserializeObject<FoodResponse>(jsonResponse);
                    foodList = foodResponse.Data;
                    lbfood.Items.Clear();
                    foreach (var food in foodList)
                    {
                        lbfood.Items.Add(food);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to load user-created food data.");
                }
            }
        }

        private async Task LoadAllFoodAsync(int currentAllPage)// Hàm load món ăn all, tương tự với hàm LoadUserCreatedFoodAsync(int) 
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(Tokens.TokenT, Tokens.AccessT);
                var requestBody = new
                {
                    current = currentAllPage, // Use currentAllPage value
                    pageSize = 5
                };
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/all", content);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var foodResponse = JsonConvert.DeserializeObject<FoodResponse>(jsonResponse);
                    foodList = foodResponse.Data;
                    lbfood.Items.Clear();
                    foreach (var food in foodList)
                    {
                        lbfood.Items.Add(food);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to load all food data.");
                }
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            btdelete_ClickAsync();
        }
        private async Task btdelete_ClickAsync()
        {
            if (lbfood.SelectedItem is Food selectedFood && selectedFood.nguoi_dong_gop == User.LoginUser)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(Tokens.TokenT, Tokens.AccessT);

                    var response = await client.DeleteAsync($"https://nt106.uitiot.vn/api/v1/monan/{selectedFood.id}");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        var delFood = JsonConvert.DeserializeObject<Food>(jsonResponse);
                        string deletef = "Xóa món ăn :"
                                         + "\n Tên món ăn" + delFood.ten_mon_an
                                         + "\n Giá:" + delFood.gia
                                         + "\n Mô tả:" + delFood.mo_ta
                                         + "\n Hình ảnh:" + delFood.hinh_anh
                                         + "\n Địa chỉ:" + delFood.dia_chi
                                         + "\n Người đóng góp:" + delFood.nguoi_dong_gop;
                        MessageBox.Show(deletef, "Món ăn hôm nay");

                        if (cList == "AllFood")
                        {
                            await LoadAllFoodAsync(cAllPage);
                        }
                        else if (cList == "UserCreatedFood")
                        {
                            await LoadUserCreatedFoodAsync(cUserPage);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa món ăn thất bại ", "Warning", MessageBoxButtons.RetryCancel);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chỉ được xóa món ăn bạn tạo ");
            }
        }

        private void btmyfood_Click(object sender, EventArgs e)
        {
            btmyfood_ClickAsync();
        }
        private async Task btmyfood_ClickAsync()
        {
            cUserPage = 1;
            cList = "UserCreatedFood";
            await LoadUserCreatedFoodAsync(cUserPage);
        }

        private void btallfood_Click(object sender, EventArgs e)
        {
            btallfood_ClickAsync();
        }
        private async Task btallfood_ClickAsync()
        {
            cAllPage = 1;
            cList = "AllFood";
            await LoadAllFoodAsync(cAllPage);
        }

        private void btpre_Click(object sender, EventArgs e)
        {
            btpre_ClickAsync();
        }
        private async Task btpre_ClickAsync()
        {
            if (cList == "AllFood")
            {
                if (cAllPage > 1)
                {
                    cAllPage--;
                    await LoadAllFoodAsync(cAllPage);
                    txtcount.Text = cAllPage.ToString();
                }
            }
            else if (cList == "UserCreatedFood")
            {
                if (cUserPage > 1)
                {
                    cUserPage--;
                    await LoadUserCreatedFoodAsync(cAllPage);
                    txtcount.Text = cUserPage.ToString();
                }
            }

        }

        private void btnext_Click(object sender, EventArgs e)
        {
            btnext_ClickAsync();
        }
        private async Task btnext_ClickAsync()
        {
            if (cList == "AllFood")
            {
                cAllPage++;
                await LoadAllFoodAsync(cAllPage);
                txtcount.Text = cAllPage.ToString();
            }
            else if (cList == "UserCreatedFood")
            {
                cUserPage++;
                await LoadUserCreatedFoodAsync(cUserPage);
                txtcount.Text = cUserPage.ToString();
            }
        }
        private List<string> entries = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            string a = "";
            string b = "";
        

            if (foodList != null && foodList.Count > 0)
            {
                foreach (var getfood in foodList)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            // Nếu chưa kết nối thì bắt đầu kết nối 
                            connect.Open();
                            // + "tenmonan = '" + getfood.ten_mon_an.Trim() + "'" + "AND" +
                            String checkusername = "SELECT * FROM foodconfig WHERE " 
                              + "hinhanh = '" + getfood.ten_mon_an.Trim() + "'";
                            using (SqlCommand checkuser = new SqlCommand(checkusername, connect))
                            {
                               
                                SqlDataAdapter adapter = new SqlDataAdapter(checkuser);
                                DataTable table = new DataTable();
                                adapter.Fill(table);
                              
                                if (table.Rows.Count >= 1)
                                {
                                
                                    MessageBox.Show(getfood.ten_mon_an.ToString() + " da ton tai roi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    // Còn nếu không sẽ chèn nội dung đăng kí vào CSDL 
                                    string insertdata = "INSERT INTO foodconfig (email,username,passsword,tenmonan,gia,mota,hinhanh,diachi)" +
                                        "VALUES(@email,@username,@pass,@foodname,@price,@info,@image,@address)";
                                    using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                                    {
                                        cmd.Parameters.AddWithValue("@email", getfood.nguoi_dong_gop.Trim()+"@gmail.com");
                                        cmd.Parameters.AddWithValue("@username", uname.Trim());
                                        cmd.Parameters.AddWithValue("@pass", pa.Trim());
                                        cmd.Parameters.AddWithValue("@foodname", getfood.ten_mon_an.Trim());
                                        cmd.Parameters.AddWithValue("@price", getfood.gia.ToString());
                                        cmd.Parameters.AddWithValue("@info", getfood.mo_ta.Trim());
                                        cmd.Parameters.AddWithValue("@image", getfood.hinh_anh.Trim());
                                        cmd.Parameters.AddWithValue("@address", getfood.dia_chi.Trim());
                                        cmd.ExecuteNonQuery();
                                        // Sau đó thông báo thành công 
                                        MessageBox.Show("Lưu dữ liệu SUCCESSFUL!!!!", "Congratulations!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                       
                                    }
                                    string ndg = getfood.nguoi_dong_gop.ToString();
                                    string tenmonan = getfood.ten_mon_an.ToString();
                                    string gia = getfood.gia.ToString();
                                    string mota = getfood.mo_ta.ToString();
                                    string diachi = getfood.dia_chi.ToString();
                                    string hinhanh = getfood.hinh_anh.ToString();
                                    a += tenmonan+"," + gia+"," + diachi+ "," + mota + "," +ndg+ "," +hinhanh + "\r\n";
                                    b = tenmonan + "," + gia + "," + diachi + "," + mota + "," + ndg + "," + hinhanh + "\r\n";
                                    entries.Add(b);
                                    b = "";
                         
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu món ăn.");
                a += "Chưa có dữ liệu món ăn";
            }
            string sub = "THÔNG TIN CÁC MÓN ĂN TẢI VỀ ";
            SendMail f1 = new SendMail(a,sub,entries);
            f1.Show();
        }
    }
}
