using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.cinema
{
    class Sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad=200;
        private bool _estaLLena = false;

        public Sala()
        {

        }

        public Sala(int capacidad, string nombre)
        {
            _capacidad = capacidad;
            _nombre = nombre;
        }

        public bool CambiaEstatus { get { return _estaLLena; }
            set
            {
                if (value == true)
                    _estaLLena = true;
            }
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int Capacidad { get { return _capacidad; } set { _capacidad = value; } }

        public override string ToString()
        {
            return "Id: " + _id + "|Nombre: " + _nombre + "|Capacidad: " + _capacidad;
        }
    }
}
