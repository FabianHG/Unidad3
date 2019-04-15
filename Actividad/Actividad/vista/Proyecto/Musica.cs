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
    public partial class Musica : Form
    {
        public Musica()
        {
            InitializeComponent();
        }
        Visualizador video;
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaInicio.Show();
            Hide();
        }

        private void pictureBoxBlame_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 3;
            video = new Visualizador(this);
            video.reproductor("\\videos\\blame.mp4");
            video.Show();
            Hide();
        }

        private void pictureBoxTuesday_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 3;
            video = new Visualizador(this);
            video.reproductor("\\videos\\tuesday.mp4");
            video.Show();
            Hide();
        }

        private void pictureBoxParadise_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 3;
            video = new Visualizador(this);
            video.reproductor("\\videos\\paradise.mp4");
            video.Show();
            Hide();
        }

        private void pictureBoxPagarte_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 3;
            video = new Visualizador(this);
            video.reproductor("\\videos\\como.mp4");
            video.Show();
            Hide();
        }
    }
}
