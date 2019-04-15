using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad.modelo.Proyecto;
using Actividad.vista.Proyecto;

namespace Actividad.vista.Proyecto
{
    public partial class Peliculas : Form
    {
        Visualizador video;
        
        public Peliculas()
        {        
            InitializeComponent();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaInicio.Show();
            Hide();
        }

        private void pictureBoxMadmax_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\madmax.mkv");
            video.Show();
            Hide();
        }

        private void pictureBoxPremonicion_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\222.mp4");
            video.Show();
            Hide();
        }

        private void pictureBoxAvengers_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\avengers.avi");
            video.Show();
            Hide();
        }

        private void pictureBoxGuardianes_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\guardianes.mkv");
            video.Show();
            Hide();
        }

        private void pictureBoxIlucionistas_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\ilucionistas.mkv");
            video.Show();
            Hide();
        }

        private void pictureBoxBatman_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\lego.mkv");
            video.Show();
            Hide();
        }

        private void pictureBoxLeyendas_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\leyendas.mkv");
            video.Show();
            Hide();
        }

        private void pictureBoxLiga_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\liga.avi");
            video.Show();
            Hide();
        }

        private void pictureBoxSicario_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\sicario.mp4");
            video.Show();
            Hide();
        }

        private void pictureBoxStar_Click(object sender, EventArgs e)
        {
            Actividad.Program.id = 1;
            video = new Visualizador(this);
            video.reproductor("\\videos\\star.mkv");
            video.Show();
            Hide();
        }
    }
}
