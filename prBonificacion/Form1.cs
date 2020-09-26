using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prBonificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int horasextras, horasnormales;
            double pagohnormal, pagohextra;
            byte nhijos;
            double sueldobruto, sueldoneto, bonificacion;
            Boolean marcado;

            horasnormales = Convert.ToInt32(txthnt.Text);
            horasextras = Convert.ToInt32(txthet.Text);

            pagohextra = Convert.ToDouble(txtphe.Text);
            pagohnormal = Convert.ToDouble(txtphn.Text);

            nhijos = Convert.ToByte(nphijos.Value);

            marcado = Convert.ToBoolean(ckbbonificacion.Checked);

            bonificacion = 0.0;

            sueldobruto = (horasnormales * pagohnormal) + (horasextras * pagohextra);

            if( marcado == true)
            {
                bonificacion = nhijos * 20;
            }

            sueldoneto = sueldobruto + bonificacion;

            txtsb.Text = " $. " + Convert.ToString(sueldobruto);
            txtsn.Text = " $. " + Convert.ToString(sueldoneto);
            txtb.Text = " $. " + Convert.ToString(bonificacion);
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            txtsb.Clear();
            txtsn.Clear();
            txtphn.Clear();
            txtphe.Clear();
            txthnt.Clear();
            txthet.Clear();
            txtb.Clear();
            ckbbonificacion.Checked = false;
            nphijos.Value = 0;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
