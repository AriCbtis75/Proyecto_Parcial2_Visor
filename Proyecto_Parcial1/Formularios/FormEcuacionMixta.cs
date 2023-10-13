using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Parcial1.Formularios
{
    public partial class FormEcuacionMixta : Form
    {
        public FormEcuacionMixta()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double valorA;
            double valorB;
            double valorC;
            double res1;
            double res2;

            valorA = double.Parse(textBoxValorA.Text);
            valorB = double.Parse(textBoxValorB.Text);
            valorC = 0;

            double potencia = valorB * valorB;
            double temp = (potencia - 4 * valorA * valorC);
            double raiz = Math.Sqrt(temp);

            res1 = (-valorB + raiz) / 2 * valorA;
            res2 = (-valorB - raiz) / 2 * valorA;

            textBoxRes1.Text = res1.ToString();
            textBoxRes2.Text = res2.ToString();
        }
    }
}
