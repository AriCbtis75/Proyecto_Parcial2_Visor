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
    public partial class FormaCalculadora : Form
    {
        public FormaCalculadora()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int v1;
            int v2;
            int res;
            v1 = int.Parse(textBoxValor1.Text);
            v2 = int.Parse(textBoxValor2.Text);
            res = v1 + v2;
            textBoxResultado.Text = res.ToString();

        }
    }
}
