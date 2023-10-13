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
    public partial class FormaDolaresEuros : Form
    {
        public FormaDolaresEuros()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float ing;
                float dol;
                float eu;

                ing = int.Parse(textBoxIngresar.Text);
                if (ing > 0)
                {
                    dol = ing / 2 / 18;
                    textBoxResDol.Text = dol.ToString();
                    eu = ing / 2 / 19;
                    textBoxResEu.Text = eu.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese valor valido");
                }
            }

            catch (Exception Error)
            {
                MessageBox.Show("Error");
            }
        }

        private void textBoxIngresar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
