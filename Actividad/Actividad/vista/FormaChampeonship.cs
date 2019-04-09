using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Actividad.modelo.campeonato;

namespace Actividad.vista
{
    public partial class FormaChampeonship : Form
    {
        private string path = @"C:\temp\campeonato.txt";

        public FormaChampeonship()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormaChampeonship_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelFechaInicio_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            Program.formaPrincipal.Show(); // Muestra la pantalla principal
            Hide();
        }

        //Metodo para cargar el data
        private void LoadGrid()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;

            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path, Encoding.Default);
                string text;

                while ((text = streamReader.ReadLine()) != null)
                {
                    string[] array = text.Split('|');
                    dataGridView1.Rows.Add(array);
                }

                streamReader.Close();
            }
            else
            {
                File.Create(path); // Crea el archivo cuando no existe
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureAdd_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (textNombre.Text.Length <3 || textNombre.Text.Length > 50)
            {
                msg += "El nombre debe estar comprendido entre 3 y 50 caracteres\n";
            }
            DateTime fechaInicio = new DateTime(dateInicio.Value.Year, dateInicio.Value.Month, dateInicio.Value.Day, 0, 0, 0);
            DateTime fechaFin = new DateTime(dateFin.Value.Year, dateFin.Value.Month, dateFin.Value.Day, 0, 0, 0);
            if (DateTime.Compare(fechaInicio, fechaFin) >= 0)
            {
                msg += "\nLa fecha Inicio debe ser menor a la fecha final";
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                Campeonato campeonato = new Campeonato();
                campeonato.Id = new Random().Next(1, 1000); //Se genera un Id Aleatorio
                campeonato.Nombre = textNombre.Text;// Caja de texto
                campeonato.FechaInicio = dateInicio.Value; //DatetimePicker Inicio
                campeonato.FechaFin = dateFin.Value; // DateTimePicker Fin

                string[] array = campeonato.ToString().Split(new char[] { '|' });
                dataGridView1.Rows.Add(array);
                AddRecordFile(campeonato);
                msg = "Registro agregado exitosamente";
                MessageBox.Show(msg, "Agrega un campeonato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AddRecordFile (Campeonato campeonato)
        {
            StreamWriter writer = new StreamWriter(path, true);

            writer.WriteLine(campeonato.ToString());
            writer.Close();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string option = e.ClickedItem.ToString().ToLower();
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = dataGridView1.SelectedCells[0].Value.ToString();
                string nombre = dataGridView1.SelectedCells[1].Value.ToString();

                switch (option)
                {
                    case "eliminar":
                        string mensaje = "¿Deseas eliminar el " + nombre + " con Id " + id;
                        contextMenuStrip1.Hide();

                        if (MessageBox.Show(mensaje, "Eliminando registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            dataGridView1.Rows.RemoveAt(row.Index);
                        }
                        break;
                    case "modificar":
                        break;
                }
            }
        }

    }
}
