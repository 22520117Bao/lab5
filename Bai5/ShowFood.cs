using System;
using System.Windows.Forms;

namespace Bai5
{
    public partial class ShowFood : Form
    {
        public ShowFood(string tenmonan, string gia, string mota, string diachi, string hinhanh)
        {
            InitializeComponent();
            ShowTheForm(tenmonan, gia, mota, diachi, hinhanh);
        }
        private void ShowTheForm(string tenmonan, string gia, string mota, string diachi, string hinhanh)
        {

            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ImageLocation = hinhanh;
            


            string a = $"Món ăn hôm nay là : {tenmonan}\r\nGiá: {gia}\r\nMô tả: {mota}\r\nĐịa chỉ: {diachi}";
            txtFood.Text = "Những thông tin về món ăn là: \r\n" + a;

        }

        private void ShowFood_Load(object sender, EventArgs e)
        {

        }

        private void txtFood_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
