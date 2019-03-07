using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.campeonato
{
    class Cancha
    {
        private int _id;
        private string _nombre;
        private string _ubicacion;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value > 0)
                {
                    this._id = value;
                }
            }
        }

        public string nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                if (value != null || (value.Length>2 && value.Length<=30))
                {
                    this._nombre = value;
                }
            }
        }

        public string ubicacion
        {
            get
            {
                return this._ubicacion;
            }
            set
            {
                if (value != null || value.Length > 3)
                {
                    this._ubicacion = value;
                }
            }
        }
    }
}
