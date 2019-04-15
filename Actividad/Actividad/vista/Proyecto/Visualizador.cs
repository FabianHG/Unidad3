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

namespace Actividad.vista.Proyecto
{
    public partial class Visualizador : Form
    {
              
        public Visualizador(Form frm)
        {
            
            InitializeComponent();
        }

        public void reproductor(string video)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + video;
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Actividad.Program.formaInicio.Show();
            Hide();
        }
               
        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            
                    if (Actividad.Program.id == 1)
                    {
                        Actividad.Program.formaPeliculas.Show();
                        Hide();
                    }
                    if (Actividad.Program.id == 2)
                    {
                        Actividad.Program.formaSeries.Show();
                        Hide();
                    }
                    if (Actividad.Program.id == 3)
                    {
                        Actividad.Program.formaMusica.Show();
                        Hide();
                    }      
        
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pictureBoxPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
