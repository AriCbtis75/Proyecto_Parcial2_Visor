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
    public partial class FormaFrecuenciaCardiaca : Form
    {
        public FormaFrecuenciaCardiaca()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float fcm;
                float edad;
                edad = float.Parse(textBoxIngresar.Text);

                if (edad > 0)
                {
                    float res;
                    fcm = 220;
                    res = fcm - edad;
                    textBoxResultado.Text = res.ToString();
                }

                else
                {
                    MessageBox.Show("Ingresa una edad valida");
                }
            }
            catch(Exception Error)
            {
                MessageBox.Show("Error");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
