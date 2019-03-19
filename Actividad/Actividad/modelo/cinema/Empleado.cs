using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.cinema
{
    class Empleado : Persona
    {
        private int _numeroEmpleado;
        private string _tipoEmpleado;

        public Empleado() :base()
        {
            _id = 1;
        }

        public Empleado(string tipo, int numero)
        {
            _numeroEmpleado = numero;
            _tipoEmpleado = tipo;
        }

        public int NumeroEmpleado
        {
            get
            {
                return _numeroEmpleado;
            }
            set
            {
                if (value > 0)
                    value = _numeroEmpleado;
            }
        }

        public string TipoEmpleado
        {
            get
            {
                return _tipoEmpleado;
            }
            set
            {
                if (value.Length > 0 && value.Length < 20)
                    value = _tipoEmpleado;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "|Numero de empleado: " + _numeroEmpleado + "|Tipo de empleado: " + _tipoEmpleado;
        }
    }
}
