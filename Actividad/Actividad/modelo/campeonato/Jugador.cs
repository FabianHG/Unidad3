using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.campeonato
{
    class Jugador
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private DateTime _fecha_Nacimiento;
        private byte _numero;
        private Equipo _idEquipo;

        public Jugador()
        {
            this._nombre = "Papulince";
            this._apellidos = "Del campo de la vía láctea";
            this._fecha_Nacimiento = DateTime.Today;
        }

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

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 30))
                {
                    this._nombre = value;
                }
            }
        }

        public string Apellidos
        {
            get
            {
                return this._apellidos;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 100))
                {
                    this._apellidos = value;
                }
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return this._fecha_Nacimiento;
            }
            set
            {
                if (value != null )
                {
                    this._fecha_Nacimiento = value;
                }
            }
        }

        public byte Numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                if (value > 0 || value<101)
                {
                    this._numero = value;
                }
            }
        }

        public Equipo IdEquipo
        {
            get
            {
                return this._idEquipo;
            }
            set
            {
                if (value != null || ((Equipo) value).Nombre.ToLower().Equals("León"))
                {
                    this._idEquipo = value;
                }
            }
        }
    }
}
