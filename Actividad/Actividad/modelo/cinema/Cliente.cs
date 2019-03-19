using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.cinema
{
    class Cliente : Persona //Definiendo herencia, todos los atributos de persona se van a pasar a cliente
    {
        public Cliente()
        {
            _nombre = "Pedro";
        }
    }
}
