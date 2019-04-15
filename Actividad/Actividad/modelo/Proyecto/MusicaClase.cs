using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.Proyecto
{
    class MusicaClase
    {
        private string _ruta;
        private int _id;

        public MusicaClase(int id, string ruta)
        {
            _id = id;
            _ruta = ruta;
        }

        public string Ruta
        {
            get { return _ruta; }
            set { }
        }
        public int Id
        {
            get { return _id; }
            set { }
        }
    }
}
