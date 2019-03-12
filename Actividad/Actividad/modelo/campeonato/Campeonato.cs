using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.campeonato
{
    class Campeonato
    {
        //Propiedades de la clase
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;

        public Campeonato()
        {
            this._nombre = "Campeonato de la segunda división Dolores";
            this._id = 1;

            for (int i = 1; i <= 20; i++)
            {
                Jornada j = new Jornada(i);
                _jornada.Add(j);
            }
        }

        //Resultado de la asociacion entre el campeonato y jornanda
        private List<Jornada> _jornada = new List<Jornada>();

        //Metodos Get y Set
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
        public string Nombre {
            get
            {
                return this._nombre;
            }
            set
            {
                if (value != null || (value.Length > 2 && value.Length <= 50))
                {
                    this._nombre = value;
                }
            }
        }
        public DateTime FechaInicio {
            get { return this._fechaInicio; }
            set
            {
                if (value > DateTime.Today && _fechaInicio < _fechaFin)
                {
                    this._fechaInicio = value;
                }
            }
        }
        public DateTime FechaFin {
            get { return this._fechaFin; }
            set
            {
                DateTime fin = new DateTime(2019, 4, 8);
                if (value <= fin)
                {
                    this._fechaFin = value;
                }
            }
        }


    }
}
