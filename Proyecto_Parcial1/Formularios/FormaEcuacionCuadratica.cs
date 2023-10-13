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
    public partial class FormaEcuacionCuadratica : Form
    {
        public FormaEcuacionCuadratica()
        {
            InitializeComponent();
        }

        private void buttonEcuacionCompleta_Click(object sender, EventArgs e)
        {
            FormEcuacionCompleta ecuacionCompleta = new FormEcuacionCompleta();
            ecuacionCompleta.Show();
        }

        private void buttonEcuacionMixta_Click(object sender, EventArgs e)
        {
            FormEcuacionMixta ecuacionMixta = new FormEcuacionMixta();
            ecuacionMixta.Show();
        }

        private void buttonEcuacionPura_Click(object sender, EventArgs e)
        {
            FormEcuacionPura ecuacionPura = new FormEcuacionPura();
            ecuacionPura.Show();
        }
    }
}
