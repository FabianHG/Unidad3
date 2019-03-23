using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.cinema
{
    class Pelicula
    {
        private int _id;
        private string _nombre;
        private string _director;
        private string _clasificacion = "A";
        private string _resumen;


        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                    _id = value;
            }
        }

        public string Nombre
        {
            get{ return _nombre; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    _nombre = value;
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

        public string Clasificacion
        {
            get { return _clasificacion; }
            set
            {
                if (value != "A")
                    _clasificacion = value;
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
        public override string ToString()
        {
            return "Id: " + _id + "|Nombre: " + _nombre + "|Director: " + _director + "|Clasificación: " + _clasificacion + "|Resumen: " + _resumen;
        }
    }
}
