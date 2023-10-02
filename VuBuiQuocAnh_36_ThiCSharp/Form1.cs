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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ("Họ và Tên: Vũ Bùi Quốc Anh" + "\nMSSV: 1223360248" + "\nNgày Thi" + DateTime.Now + "\nMôn Thi: Lập Trình Window 2 - C#");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương Trình Tiện Ích", "Thông Tin");
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongtrinhBac2 giaiPhuongtrinhBac2 = new GiaiPhuongtrinhBac2();
            giaiPhuongtrinhBac2.Show();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           dinhdang dinhdang = new dinhdang();
            dinhdang.Show();
        }
    }
}
