using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class ShowEmail : Form
    {
        public ShowEmail(string content, string su, string dt, string fr)
        {
            InitializeComponent();
            richTextBox1.Text =  su + "\r\n" 
                                +fr+ "\r\n"
                                +dt+"\r\n"
                                +content;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
