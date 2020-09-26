using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prEstructuraMultiple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            byte numero;
            string dia;

            numero = Convert.ToByte(txtNumero.Text);

            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Error Ingrese un nuevo numero";
                    break;
            }
            txtDiadelaSemana.Text = dia;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDiadelaSemana.Clear();
            txtNumero.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
