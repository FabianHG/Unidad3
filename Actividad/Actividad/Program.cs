using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad.vista;
using Actividades.vista;
using Actividad.vista.Proyecto;
namespace Actividad
{
    static class Program
    {
        public static FormaChampeonship formaCampeonato = null;
        public static Principal formaPrincipal = null;
        public static Inicio formaInicio = null;
        public static Peliculas formaPeliculas = null;
        public static Series formaSeries = null;
        public static Reproductor formaReproductor = null;
        public static Musica formaMusica = null;
        public static Agregar formaAgregar = null;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formaPrincipal = new Principal();
            formaCampeonato = new FormaChampeonship();
            formaInicio = new Inicio();
            formaPeliculas = new Peliculas();
            formaSeries = new Series();
            formaReproductor = new Reproductor();
            formaMusica = new Musica();
            formaAgregar = new Agregar();
            Application.Run(new Inicio());

        }
    }
}
