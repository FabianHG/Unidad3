using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.cinema
{
    class Asiento
    {
        private int _numero;
        private bool _estaDisponible;

        public void CambiarDisponibilidad(bool disponible)
        {
            _estaDisponible = disponible;
        }
        public override string ToString()
        {
            return "Número: " + _numero + "|Disponible: " + _estaDisponible;
        }
    }
}
