using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuBuiQuocAnh_36_ThiCSharp
{
    public partial class GiaiPhuongtrinhBac2 : Form
    {
        public GiaiPhuongtrinhBac2()
        {
            InitializeComponent();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            int intA, intB, intC;
            double x1, x2, delta;
            intA = Convert.ToInt32(txta.Text);
            intB = Convert.ToInt32(txtb.Text);
            intC = Convert.ToInt32(txtc.Text);
            if (intA == 0)
            {
                if (intB == 0)
                {
                    if (intC == 0)
                    {
                        lblketqua.Text = "Phương Trình Có Vô Số Nghiệm";
                    }
                    else
                    {
                        lblketqua.Text = "Phương Trình Vô Nghiệm";
                    }
                }
                else
                {
                    x1 = (double)-intC / intB;
                    lblketqua.Text = "Phương Trình Có Nghiệm Duy Nhất";
                    lblketqua.Text += "" + x1;
                }

            }
            else
            {
                delta = Math.Pow(intB, 2) - 4 * intA * intC;
                if (delta < 0)
                {
                    lblketqua.Text = "Phương Trình Có Vô Số Nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -intB / (2 * intA);
                    lblketqua.Text = "Phương Trình Vô Nghiệm";
                }
                else
                {
                    x1 = (-intB + Math.Sqrt(delta)) / (2 * intA);
                    x2 = (-intB - Math.Sqrt(delta)) / (2 * intA);
                    lblketqua.Text = "Phương Trình Có Hai Nghiệm Phân Biệt" + "\n" + "x1= " + (x1) + "\n" + "x2= " + (x2);
                }
            }
        }
    }
}


