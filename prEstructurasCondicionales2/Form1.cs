using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prEstructurasCondicionales2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pxCuadrado.Visible = false;
            pxRectangulo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB;
            double Area, Perimetro;

            ladoA = Convert.ToDouble(txtLadoA.Text);
            ladoB = Convert.ToDouble(txtLadoB.Text);

            if(ladoA == ladoB)
            {
                pxCuadrado.Visible = true;
                pxRectangulo.Visible = false;
            }
            else
            {
                pxRectangulo.Visible = true;
                pxCuadrado.Visible = false;
            }

            Area = ladoA * ladoB;
            Perimetro = 2 * (ladoA + ladoB);

            txtArea.Text = Convert.ToString(Area);
            txtPerimetro.Text = Convert.ToString(Perimetro);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPerimetro.Clear();
            txtLadoB.Clear();
            txtLadoA.Clear();
            txtArea.Clear();
            pxCuadrado.Visible = false;
            pxRectangulo.Visible = false;
        }
    }
}
