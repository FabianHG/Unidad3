using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.Proyecto
{
    class Categoria
    {
        private int _id;
        private string _nombre;
        private byte _cantidadVideos;
        private bool _estaDisponible;
        private DateTime _fecha;

        public Categoria()
        {

        }
        public Categoria(string nombre)
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
        public byte CantidadVideos
        {
            get { return _cantidadVideos; }
            set
            {
                if (value > 0)
                    _cantidadVideos = value;
            }
        }
        public bool EstaDisponible
        {
            get { return _estaDisponible; }
            set { }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set
            {
                if (value >= DateTime.Today || value <= DateTime.Today)
                    _fecha = value;
            }
        }
    }
}
