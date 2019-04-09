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
    public partial class Peliculas : Form
    {
       
        public Peliculas()
        {
            InitializeComponent();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaInicio.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxStar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMadmax_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaReproductor.Show();
            
            Hide();
        }
    }
}
