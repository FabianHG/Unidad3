using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.vista.Proyecto
{
    public partial class Reproductor : Form
    {
        private string rutaMadmax = @"C:\Users\fabya\Desktop\Proyecto - Programacion\Videos - Peliculas\Mad Max.mkv";
        public Reproductor()
        {
            InitializeComponent();
        }

        private void Reproductor_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = rutaMadmax;
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaInicio.Show();
            Hide();
        }

    }
}
