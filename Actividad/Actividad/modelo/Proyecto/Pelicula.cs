﻿using System;
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
        private string _ruta;
        private string _resumen;

        public Pelicula()
        {

        }
        public Pelicula(int id, string ruta)
        {
            _id = id;
            _ruta = ruta;
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
        public string Ruta
        {
            get { return _ruta; }
            set
            {
              
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
