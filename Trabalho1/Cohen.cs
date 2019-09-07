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
    public partial class Cohen : Form
    {
        Bitmap image;
        int xmin, xmax, ymin, ymax;
        
        public Cohen()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);
            int c1, c2, cfora;
            int xint,yint;

            bool aceite, feito;

            aceite = false;
            feito = false;

            while (!feito)
            {
                c1 = region_code(x1, y1);
                c2 = region_code(x2, y2);
                if(c1 == 0 && c2 == 0)
                {
                    aceite = true;
                    feito = true;
                }
                else if(c1 != 0 && c2 != 0)
                {
                    feito = true;
                }
                else
                {
                    if(c1 != 0)
                    {
                        cfora = c1;
                    }
                    else
                    {
                        cfora = c2;
                    }
                    if (image.GetPixel(cfora, 0) == Color.Black)
                    {
                        xint = xmin;
                        yint = y1 + (y2 - y1) * (xmin - x1) / (x2 - x1);

                    }
                    else if (image.GetPixel(cfora, 1) == Color.Black)
                    {
                        xint = xmax;
                        yint = y1 + (y2 - y1) * (xmax - x1) / (x2 - x1);
                    }
                    else if (image.GetPixel(cfora, 2) == Color.Black)
                    {
                        yint = ymin;
                        xint = x1 + (x2 - x1) * (ymin - y1) / (y2 - y1);
                    }
                    else
                    {
                        yint = ymax;
                        xint = x1 + (x2 - x1) * (ymax - y1) / (y2 - y1);
                    }

                    if (c1 == cfora)
                    {
                        x1 = xint;
                        y1 = yint;
                    }
                    else
                    {
                        x2 = xint;
                        y2 = yint;
                    }

                }
               
            }
            if (aceite)
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

        private int region_code(int x, int y)
        {
            int codigo = 0;

            if(x < xmin)
            {
                codigo = codigo + 1;
            }
            if(x > xmax)
            {
                codigo = codigo + 2;
            }
            if(y < ymin)
            {
                codigo = codigo + 4;
            }
            if(y > ymax)
            {
                codigo = codigo + 8;
            }
            return codigo;
        }
    }
}
