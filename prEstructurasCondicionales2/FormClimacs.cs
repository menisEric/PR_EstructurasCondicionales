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
    public partial class FormClimacs : Form
    {
        public FormClimacs()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            byte Temperatura;
            string clima;

            Temperatura = Convert.ToByte(txtTemperatura.Text);

            if(Temperatura < 10)
            {
                clima = "Frio";
            }
            else if(Temperatura >= 10 && Temperatura <= 20)
            {
                clima = "Templado";
            }
            else if(Temperatura > 20 && Temperatura <= 30)
            {
                clima = "Calor";
            }
            else
            {
                clima = "Tropical";
            }

            txtClima.Text = clima;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtClima.Clear();
            txtTemperatura.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
