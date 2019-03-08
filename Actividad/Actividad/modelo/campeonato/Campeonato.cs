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
        public int Id { get; set; }
        public int Nombre { get; set; }
        public int FechaInicio { get; set; }
        public int FechaFin { get; set; }
    }
}
