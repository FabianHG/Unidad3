using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividades.modelo;

namespace Actividades.vista
{
    public partial class FormaEstudiante : Form
    {
        public FormaEstudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormaEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Estudiante student01 = new Estudiante();
            student01.NumeroControl = 1218100604;
            student01.Nombre = "Fabian Hernandez Guerrero";
            student01.Edad = 22;
            student01.Genero = 'H';

            textoNumeroControl.Text = student01.NumeroControl.ToString();
            textoNombre.Text = student01.Nombre;
            textoEdad.Text = student01.Edad.ToString();
            textGenero.Text = student01.Genero.ToString();
        }
    }
}
