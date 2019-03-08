using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.campeonato
{
    class Partido
    {
        private int _id;
        private string _descripcion;
        private DateTime _fecha;
        private bool _isFinalizado;
        private string _observaciones;
        
        //Se asocia con clase Cancha
        private Cancha _cancha;
        
        //Se asocia Partidos con dos Equipos
        private Equipo _local;
        private Equipo _visitante;

        //Se asocia con Jornada
        private Jornada _jornada;
        
        //Se asocia con Arbitro
        private Arbitro _arbitro1;
        private Arbitro _arbitro2;
        // private Arbitro[] arbitros;

        public Partido()
        {
            this._isFinalizado = false;
            this._id = 1;
            Random alea = new Random();
            int dia = alea.Next(1, 31);
            this._fecha = new DateTime(2019, 3, dia, 16, 0, 0);
        }

        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this._local = equipo1;
            this._visitante = equipo2;
        }

        public void addCancha (Cancha c)
        {
            this._cancha = c;
        }

        public Partido(Arbitro arbitro1, Arbitro arbitro2)
        {
            this._arbitro1 = arbitro1;
            this._arbitro2 = arbitro2;
        }

        public Partido(Jornada jornada)
        {
            this._jornada = jornada;
        }

       

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public Boolean IsFinalizado { get; set; }
        public string Observaciones { get; set; }
    }
}
