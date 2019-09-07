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
    public partial class Retas : Form
    {
        public Retas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            drawLineWithBresenham(p1, p2);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void drawLineWithBresenham(Point from, Point to)
        {
            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            int dx, dy, x, y, const1, const2, p;
            dx = to.X - from.X;
            dy = to.Y = from.Y;

            p = 2 * dy - dx;

            const1 = 2 * dy;

            const2 = 2 * (dy - dx);
            x = from.X;
            y = from.Y;

            image.SetPixel(x, y, Color.Black);
            while(x < to.X)
            {
                x = x + 1;
                if(p < 0)
                {
                    p += const1;
                }
                else
                {
                    p += const2;
                    y++;
                }
                image.SetPixel(x, y, Color.Black);
            }

            pictureBox1.Image = image;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            DDA(p1, p2);
        }

        private void DDA(Point p1, Point p2)
        {
            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int dx, dy, steps, k;
            double x_incr, y_incr, x, y;

            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;


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
            x = p1.X;
            y = p1.Y;

            image.SetPixel((int)x, (int)y, Color.Black);

            for(int i = 0;i < steps; i++)
            {
                x = x + x_incr;
                y = y + y_incr;
                image.SetPixel((int)x, (int)y, Color.Black);
            }

            pictureBox1.Image = image;
        }
    }
}