using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.cinema
{
    class Cartelera
    {
        private int _id;
        private DateTime _fecha;
        private string _horario;
        private string _tipo = "3D";
        private double _costo;

        public void AgregarPelicula(Pelicula pelicula, Sala sala, DateTime fecha, string horario, string tipo)
        {
            _fecha = fecha;
            _horario = horario;
            _tipo = tipo;
        }

        public void EliminarPelicula(Pelicula pelicula)
        {
     
        }

        public int Id { get { return _id; } set { _id = value; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Horario { get { return _horario; } set { _horario = value; } }
        public string Tipo { get { return _tipo; } set { _tipo = value; } }
        public double costo { get { return _costo; } set { _costo = value; } }

        public override string ToString()
        {
            return "Id: " + _id + "|Fecha: " + _fecha + "|Horario: " + _horario + "|Tipo: " + _tipo + "|Costo: " + _costo;
        }

    }
}
