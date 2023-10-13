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
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuVideo01_Click(object sender, EventArgs e)
        {
            FormaVideo video = new FormaVideo();
            video.Show();
            Hide();

        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaRegistro registro = new FormaRegistro();
            registro.Show();
            Hide();
        }

        private void calculadoraMenu_Click(object sender, EventArgs e)
        {
            FormaCalculadora calculadora = new FormaCalculadora();
            calculadora.Show();
            
        }

        private void areaDeUnTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaAreaTriangulo areaTriangulo = new FormaAreaTriangulo();
            areaTriangulo.Show();
            
        }

        private void dolaresYEurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaDolaresEuros dolaresEuros = new FormaDolaresEuros();
            dolaresEuros.Show();
            
        }

        private void frecuenciaCardiacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaFrecuenciaCardiaca frecuenciaCardiaca = new FormaFrecuenciaCardiaca();
            frecuenciaCardiaca.Show();
             
        }

        private void nuevoSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaAumentoSalario aumentoSalario = new FormaAumentoSalario();
            aumentoSalario.Show();
            
        }

        private void ecuacionCuadraticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEcuacionCuadratica ecuacionCuadratica = new FormaEcuacionCuadratica();
            ecuacionCuadratica.Show();
            
        }

        private void visorDeImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaVisorImagen visorImagen = new FormaVisorImagen();
            visorImagen.Show();
        }
    }
}
