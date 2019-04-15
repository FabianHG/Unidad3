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
    public partial class Series : Form
    {
        public Series()
        {
            InitializeComponent();
        }
        Visualizador video;

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaInicio.Show();
            Hide();
        }

        private void buttonCap1_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 2;
            video = new Visualizador(this);
            video.reproductor("\\videos\\1910.MP4");
            video.Show();
            Hide();
        }

        private void buttonCap2_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 2;
            video = new Visualizador(this);
            video.reproductor("\\videos\\2010.MP4");
            video.Show();
            Hide();
        }

        private void buttonCap3_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 2;
            video = new Visualizador(this);
            video.reproductor("\\videos\\2110.MP4");
            video.Show();
            Hide();
        }

        private void buttonPoke1_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 2;
            video = new Visualizador(this);
            video.reproductor("\\videos\\pokemon1.mp4");
            video.Show();
            Hide();
        }

        private void buttonPoke2_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 2;
            video = new Visualizador(this);
            video.reproductor("\\videos\\pokemon2.mp4");
            video.Show();
            Hide();
        }

        private void buttonPoke3_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 2;
            video = new Visualizador(this);
            video.reproductor("\\videos\\pokemon3.mp4");
            video.Show();
            Hide();
        }
        
    }
}
