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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Retas retas = new Retas();
            retas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Circunferencia circunferencia = new Circunferencia();
            circunferencia.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Cohen cohen = new Cohen();
            cohen.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Liang_Barsky liang_Barsky = new Liang_Barsky();
            liang_Barsky.ShowDialog();
        }
    }
}
