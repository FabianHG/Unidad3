using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.cinema
{
    class Reservacion
    {
        private DateTime _fecha;
        private string _numeroTarjeta;

        public Reservacion()
        {

        }

        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        public string NumeroTarjeta { get { return _numeroTarjeta; } set { _numeroTarjeta = value; } }

        public override string ToString()
        {
            return "Fecha: " + _fecha + "|Número de Tarjeta: " + _numeroTarjeta;
        }
    }
}
