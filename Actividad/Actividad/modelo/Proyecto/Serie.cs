using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.Proyecto
{
    class Serie : Video
    {
        private string _nombreSerie;
        private byte _temporada;
        private byte _numeroCapitulo;
        private char _clasificacion;
        private string _protagonista;
        
        public Serie()
        {

        }
        public Serie(byte temporada, byte numeroCap)
        {
            temporada = _temporada;
            numeroCap = _numeroCapitulo;
        }

        public string NombreSerie
        {
            get { return _nombreSerie; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    _nombreSerie = value; 
            }
        }
        public byte Temporada
        {
            get { return _temporada; }
            set
            {
                if (value > 0)
                    _temporada = value;
            }
        }
        public byte NumeroCapitulo
        {
            get { return _numeroCapitulo; }
            set
            {
                if (value > 0)
                    _numeroCapitulo = value;
            }
        }
        public string Protagonista
        {
            get { return _protagonista; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                    _protagonista = value;
            }
        }

    }
}
