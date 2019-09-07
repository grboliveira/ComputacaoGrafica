using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1
{
    public partial class Circunferencia : Form
    {

        private Bitmap image;
        public Circunferencia()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int xc = Convert.ToInt32(textBox1.Text);
            int yc = Convert.ToInt32(textBox2.Text);
            int r = Convert.ToInt32(textBox3.Text);

            int x = 0;
            int y = r;
            int p = 3 - (2 * r);
            plot_circle_points(xc, yc, x, y);
            while(x < y)
            {
                if (p < 0)
                {
                    p = p + (4 * x) + 6;
                }
                else
                {
                    p = p + 4 * (x - y) + 10;
                    y = y - 1;
                }
                x = x + 1;
                plot_circle_points(xc, yc, x, y);

            }
            
            
        }

        private void plot_circle_points(int xc, int yc, int x, int y)
        {
            image.SetPixel(xc+x, yc+y, Color.Black);
            image.SetPixel(xc-x, yc+y, Color.Black);
            image.SetPixel(xc+x, yc-y, Color.Black);
            image.SetPixel(xc-x, yc-y, Color.Black);
            image.SetPixel(xc+y, yc+x, Color.Black);
            image.SetPixel(xc-y, yc+x, Color.Black);
            image.SetPixel(xc+y, yc-x, Color.Black);
            image.SetPixel(xc-y, yc-x, Color.Black);
        }
    }
}
