using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuBuiQuocAnh_36_ThiCSharp
{
    public partial class dinhdang : Form
    {
        public dinhdang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Text = txtnhapten.Text;
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.LimeGreen;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Black;
        }

        private void ckbdam_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Underline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
