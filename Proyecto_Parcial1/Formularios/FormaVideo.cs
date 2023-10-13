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
    public partial class FormaVideo : Form
    {
        public FormaVideo()
        {
            InitializeComponent();
        }

        private void FormaVideo_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\DAENX LAPS\Documents\Ba\Stay.mp4";
        }
    }
}
