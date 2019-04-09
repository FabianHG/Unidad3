using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.Proyecto
{
    class Pelicula : Video
    {
        private char _clasificacion;
        private string _director;
        private DateTime _estreno;
        private string _actores;
        private string _resumen;

        public Pelicula()
        {

        }
        public Pelicula(char clasificacion, string resumen)
        {
            clasificacion = _clasificacion;
            resumen = _resumen;
        }

        public char Clasificacion
        {
            get { return _clasificacion; }
            set
            {
                if (value > 0)
                    value = _clasificacion;
            }
        }
        public string Director
        {
            get { return _director; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    _director = value;
            }
        }
        public DateTime Estreno
        {
            get { return _estreno; }
            set
            {
                if (value>=DateTime.Today || value<=DateTime.Today)
                    _estreno = value;
            }
        }
        public string Actores
        {
            get { return _actores; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    _actores = value;
            }
        }
        public string Resumen
        {
            get { return _resumen; }
            set
            {
                if (value.Length >= 3 && value.Length <= 200)
                    _resumen = value;
            }
        }
    }
}
