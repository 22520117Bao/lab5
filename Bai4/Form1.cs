using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;
using System.Text.Json;
using System.IO;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSL.Enabled = false;
            txtposter.Enabled = false;
            txtprice.Enabled = false;   
            txtremain.Enabled = false;  
            txtsum.Enabled = false;
            txtname.Enabled = false;
            ckP1.Enabled = false;
            ckP2.Enabled = false;   
            ckP3.Enabled = false;
        }
        static int n = 0;
        List<Phim> Phims = new List<Phim>();

        private void SerializeJson(object obj, string Filepath)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(Filepath, json);
        }
        private List<Phim> DeserializeJson(string Filepath)
        {
            string json = File.ReadAllText(Filepath);
            List<Phim> Phims = JsonSerializer.Deserialize<List<Phim>>(json);
            return Phims;
        }
        private static void RankPhim(List<Phim> phimList)
        {

            for (int i = 0; i < phimList.Count - 1; i++)
            {
                for (int j = 0; j < phimList.Count - 1 - i; j++)
                {
                    if (phimList[j].TongTien < phimList[j + 1].TongTien)
                    {
                        Phim temp = phimList[j];
                        phimList[j] = phimList[j + 1];
                        phimList[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < phimList.Count; i++)
            {
                phimList[i].Rank = i + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                Phims = DeserializeJson("output5.txt");
                RankPhim(Phims);
                richTextBox1.Clear();
                int progressStep = 100 / Phims.Count;
                foreach (var allphim in Phims)
                {
                    progressBar1.Value += progressStep;
                    progressBar1.Refresh();

                    richTextBox1.Text += "Tên phim: " + allphim.TenPhim + '\n';
                    double vetong = 0;
                    double veban = 0;
                    foreach (Phim.CPhong onlyphim in allphim.Phong)
                    {
                        vetong += 15;
                        veban += onlyphim.suat.Length;
                    }
                    richTextBox1.Text += "Số lượng vé bán ra: " + (vetong - veban).ToString() + '\n' + "Lượng vé còn lại : " + veban.ToString() + '\n';
                    richTextBox1.Text += "Tỉ lệ vé: " + (((vetong - veban) / vetong) * 100).ToString("0.0") + "%" 
                        + '\n' + "Doanh thu: " + allphim.TongTien.ToString() + '\n' + "Ranking: " + allphim.Rank + "\n\n";
                }

            }
            catch (JsonException)
            {
                MessageBox.Show("File lỗi không thể truy xuất ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btcreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn hãy bắt đầu tạo vé bằng cách nhập số lượng vào ô số lượng phim dưới đây", "INFO", MessageBoxButtons.OK);
            txtSL.Enabled = true;
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtSL.Text, out int temp))
            {
                MessageBox.Show(@"Hãy nhập số nguyên vào đây: ""Số lượng"": ");
                return;
            }
            n = temp;
            txtsum.Text = n.ToString();
            txtremain.Text = n.ToString();
            MessageBox.Show("Bắt đầu nhập dữ liệu cho phim");

            EnableInput();
        }
        private void EnableInput()
        {
            txtposter.Enabled = true;
            txtprice.Enabled = true;
            txtremain.Enabled = true;
            txtsum.Enabled = true;
            txtname.Enabled = true;
            ckP1.Enabled = true;
            ckP2.Enabled = true;
            ckP3.Enabled = true;
            txtSL.Visible = false;
            label2.Visible = false;
        }

        private void btdatve_Click(object sender, EventArgs e)
        {
           
            Form2 form2 = new Form2();
            form2.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Phim Phim = new Phim();
                int num = Int32.Parse(txtremain.Text);
                Phim.TenPhim = txtname.Text;
                if (ckP1.CheckState == CheckState.Checked)
                {
                    Phim.Phong.Add(new Phim.CPhong { TenPhong = ckP1.Text.Trim() });
                }
                if (ckP2.CheckState == CheckState.Checked)
                {
                    Phim.Phong.Add(new Phim.CPhong { TenPhong = ckP2.Text.Trim() });
                }
                if (ckP3.CheckState == CheckState.Checked)
                {
                    Phim.Phong.Add(new Phim.CPhong { TenPhong = ckP3.Text.Trim() });
                }
                Phim.GiaVe = Int32.Parse(txtprice.Text);
                Phim.ImageUrl = txtposter.Text.Trim();
                txtremain.Text = (num - 1).ToString();
                {
                    Phims.Add(Phim);
                    MessageBox.Show("Bạn đã nhập thành công" +txtname.Text+ "bạn cần nhập tiếp"+ txtremain+ "để hoàn thành","Info");
                    txtname.Text = "";
                    txtprice.Text = "";
                    txtposter.Text = "";
                    ckP1.CheckState = CheckState.Unchecked;
                    ckP2.CheckState = CheckState.Unchecked;
                    ckP3.CheckState = CheckState.Unchecked;
                    txtsum.Enabled = false;
                   
                }
                if (txtremain.Text == "0")
                {
                    MessageBox.Show($"Bạn đã hết lần nhập", "Thành công", MessageBoxButtons.OK);
                    SerializeJson(Phims, "input5.txt");
                    SerializeJson(Phims, "output5.txt");
                    txtSL.Enabled = false;
                    txtposter.Enabled = false;
                    txtprice.Enabled = false;
                    txtremain.Enabled = false;
                    txtsum.Enabled = false;
                    txtname.Enabled = false;
                    ckP1.Enabled = false;
                    ckP2.Enabled = false;
                    ckP3.Enabled = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtposter.Text = openFileDialog.FileName;
            }
        }
    }
}
