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
    public partial class FormaAumentoSalario : Form
    {
        public FormaAumentoSalario()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int salario;
                salario = int.Parse(textBoxIngresar.Text);
                if (salario > 0)
                {
                    int res;
                    int porcentaje;
                    porcentaje = salario / 4;
                    res = salario + porcentaje;

                    textBoxSalario.Text = res.ToString();
                }
                else 
                {
                    MessageBox.Show("Ingresa sueldo valido");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
