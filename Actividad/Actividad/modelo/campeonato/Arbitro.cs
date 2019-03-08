using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.campeonato
{
    class Arbitro
    {
        private int _aniosExperiencia;
        private bool _tieneGafete;
        private Partido _partido;

        public void addObservaciones(Partido p)
        {
            this._partido = p;
        }
    }
}
