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
    public partial class FormEcuacionPura : Form
    {
        public FormEcuacionPura()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            double valorA;
 
            double valorC;
            double res1;
            double temp;

            valorA = double.Parse(textBoxValorA.Text);
            valorC = double.Parse(textBoxValorC.Text);
            temp = -1 * valorC;

            res1 = valorC / valorA;
            double cant1 = Math.Sqrt(res1);
            double cant2 = Math.Sqrt(- res1);

            textBoxRes1.Text = cant1.ToString();
            textBoxRes2.Text = cant2.ToString();
        }
    }
}
