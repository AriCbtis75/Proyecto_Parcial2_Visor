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
    public partial class FormaAreaTriangulo : Form
    {
        public FormaAreaTriangulo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float alt;
                float ba;
                float res;

                alt = float.Parse(textBoxAltura.Text);
                ba = float.Parse(textBoxBase.Text);

                if (alt > 0 & ba > 0 ) 
                { 
                res = alt * ba / 2;
                textBoxResultado.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa un valor valido");
                }
            }

            catch (Exception Error)
            {
                MessageBox.Show("Error");
            }
        
        }
    }
}
