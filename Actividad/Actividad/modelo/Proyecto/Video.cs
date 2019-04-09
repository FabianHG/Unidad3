using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.Proyecto
{
    class Video
    {
        private int _id;
        private string _nombre;
        private int _duracion;
        private DateTime _fecha;
        private bool _estaDisponible;

        public Video()
        {

        }
        public Video(string nombre, int duracion)
        {
            nombre = _nombre;
            duracion = _duracion;
        }

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
            get { return _nombre; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    _nombre = value;
            }
        }
        public int Duracion
        {
            get { return _duracion; }
            set
            {
                if (value > 0)
                    _duracion = value;
            }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set
            {
                if (value > DateTime.Today)
                {
                    value = _fecha;
                }
            }
        }
        public bool EstaDisponible
        {
            get { return _estaDisponible; }
            set { }
        }
    }
}
