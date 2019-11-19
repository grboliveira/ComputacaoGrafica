using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPCG
{
    
    public partial class tela : Form
    {
        Bitmap areaDesenho;
        Color corPreenche;
        private PointF[] Points = new PointF[4];
        private int NextPoint = 0;
        Graphics g;
        public tela()
        {
            InitializeComponent();
            corPreenche = Color.Black;
            areaDesenho = new Bitmap(imagem.Size.Width, imagem.Size.Height);
            
            imagem.Image = areaDesenho;
            g = Graphics.FromImage(areaDesenho);
            //imagem.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
        }

        

        private void desenhar_Click(object sender, EventArgs e)
        {
            //int x = (int)Convert.ToInt64(txtX.Text);
            //int y = (int)Convert.ToInt64(txtY.Text);

            
            //areaDesenho = new Bitmap(imagem.Size.Width, imagem.Size.Height);

            //areaDesenho.SetPixel(x, y, corPreenche);
            //imagem.Image = areaDesenho;
        }

        private void btCor_Click(object sender, EventArgs e)
        {
            DialogResult result = cdlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                corPreenche = cdlg.Color;
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            areaDesenho = new Bitmap(imagem.Size.Width, imagem.Size.Height);
            imagem.Image = areaDesenho;
            
        }

        private void imagem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (NextPoint > 3) NextPoint = 0;

                // Save this point.
                Points[NextPoint].X = e.X;
                Points[NextPoint].Y = e.Y;

                // Move to the next point.
                NextPoint++;
                // Redraw.

                if (NextPoint > 3)
                {
                    //imagem.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
                }
                /*
                if (e.Button == MouseButtons.Left)
                {
                    int x = e.X;
                    int y = e.Y;

                    txtX.Text = Convert.ToString(x);
                    txtY.Text = Convert.ToString(y);

                    areaDesenho.SetPixel(x, y, corPreenche);
                    imagem.Image = areaDesenho;
                }
                */

            }
        }



        private void lbY_Click(object sender, EventArgs e)
        {

        }
        private void picCanvas_Paint()
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(imagem.BackColor);
            if (NextPoint >= 4)
            {
                // Desenha a curva de Bezier.
                Bezier.DrawBezier(g, Pens.Black, 0.01f,
                    Points[0], Points[1], Points[2], Points[3]);
            }

            // Desenha os pontos definidos
            for (int i = 0; i < NextPoint; i++)
            {
                g.FillRectangle(Brushes.White,
                    Points[i].X - 3, Points[i].Y - 3, 6, 6);
                g.DrawRectangle(Pens.Black,
                    Points[i].X - 3, Points[i].Y - 3, 6, 6);
            }
           
            imagem.Image = areaDesenho;
        }

        private void imagem_Click(object sender, EventArgs e)
        {
            if (NextPoint > 3) NextPoint = 0;

            // Save this point.
            Points[NextPoint].X = MousePosition.X;
            Points[NextPoint].Y = MousePosition.Y;

            areaDesenho.SetPixel((int)Points[NextPoint].X, (int)Points[NextPoint].Y, corPreenche);
            imagem.Image = areaDesenho;

            // Próximo ponto
            NextPoint++;
            // Redesenha

            if (NextPoint > 3)
            {
                //imagem.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
                picCanvas_Paint();
            }
            /*
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;

                txtX.Text = Convert.ToString(x);
                txtY.Text = Convert.ToString(y);

                areaDesenho.SetPixel(x, y, corPreenche);
                imagem.Image = areaDesenho;
            }
            */

        }
    
    }
}
