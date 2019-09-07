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
    public partial class Liang_Barsky : Form
    {
        int xjmin, xjmax, yjmin, yjmax;
        public Liang_Barsky()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);
            float u1, u2;
            int dx = x2 - x1;
            int dy = y2 - y1;
            u1 = 0;
            u2 = 0;
            if(cliptest(-dx,x1 - xjmin, u1, u2))
            {
                if(cliptest(dx, xjmax - x1, u1, u2))
                {
                    if(cliptest(-dy, y1 - yjmin, u1, u2))
                    {
                        if(cliptest(dy, yjmax - y1, u1, u2))
                        {
                            if(u2 < 1.0)
                            {
                                x2 = x1 + (int)u2 * dx;
                                y2 = y1 + (int)u2 * dy;
                            }
                            if(u1 > 0.0)
                            {
                                x1 = x1 + (int)u1 * dx;
                                y1 = y1 + (int)u1 * dy;
                            }
                            desenha_linha(x1, y1, x2, y2);
                        }
                    }
                }
            }
        }

        private bool cliptest(int p, int q, float u1, float u2)
        {
            bool result = true;
            if(p < 0)
            {
                float r = q / p;
                if(r > u2)
                {
                    result = false;
                }
                else if(r > u1)
                {
                    u1 = r;
                }
            }
            else if(p > 0)
            {
                float r = q / p;
                if(r < u1)
                {
                    result = false;
                }
                else if(r < u2)
                {
                    u2 = r;
                }
            }
            else if(q< 0)
            {
                result = false;
            }
            return false;
        }

        public void desenha_linha(int x1, int y1, int x2, int y2)
        {
            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int dx, dy, steps, k;
            double x_incr, y_incr, x, y;

            dx = x2 - x1;
            dy = y2 - y1;


            if (dx > dy)
            {
                steps = dx;
            }
            else
            {
                steps = dy;
            }

            x_incr = (dx / steps);
            y_incr = (dy / steps);
            x = x1;
            y = y1;

            image.SetPixel((int)x, (int)y, Color.Black);

            for (int i = 0; i < steps; i++)
            {
                x = x + x_incr;
                y = y + y_incr;
                image.SetPixel((int)x, (int)y, Color.Black);
            }

            pictureBox1.Image = image;
        }
    }
}
