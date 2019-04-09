using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.Proyecto
{
    class Reproductor
    {
        private int _id;
        private string _nombre;
        private bool _esDisponible;
        private DateTime _fechaEjecucion;
        private DateTime _fechaTermino;

        public Reproductor()
        {
        }
        public Reproductor(string nombre)
        {
            nombre = _nombre;
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
        public bool EsDisponible
        {
            get { return _esDisponible; }
            set { }
        }
        public DateTime FechaEjecucion
        {
            get { return _fechaEjecucion; }
            set { value = _fechaEjecucion; }
        }
        public DateTime FechaTermino
        {
            get { return _fechaTermino; }
            set { value = _fechaTermino; }
        }
    }
}
