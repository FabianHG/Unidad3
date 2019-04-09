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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaInicio.Show();
            Hide();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Actividad.Program.formaPeliculas.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaSeries.Show();
            Hide();
        }

        private void labelPeliculas_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaPeliculas.Show();
            Hide();
        }

        private void labelSeries_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaSeries.Show();
            Hide();
        }
        
        private void Agregar_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaAgregar.Show();
            Hide();
        }

        private void pictureBoxMusica_Click(object sender, EventArgs e)
        {
            Actividad.Program.formaMusica.Show();
            Hide();
        }
    }
}
