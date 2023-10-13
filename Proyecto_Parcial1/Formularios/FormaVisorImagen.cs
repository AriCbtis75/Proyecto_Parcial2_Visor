using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_Parcial1.Formularios
{
    public partial class FormaVisorImagen : Form
    {
        Image img;
        public FormaVisorImagen()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void buttonBackgroud_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                buttonShow.Font = Font;
                buttonClean.Font = Font;
                buttonBackgroud.Font = Font;
                buttonClose.Font = Font;
                buttonQuitar.Font = Font;
                buttonRegresar.Font = Font;
                buttonSave.Font = Font;
                checkBoxAjustar.Font = Font;
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(saveFileDialog1.FileName);
            }
        }

        private void checkBoxAjustar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAjustar.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
      
    }
}
