using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.modelo.cinema
{
    class MockObjetos
    {
        public static Sala[] coleccionSalas()
        {
            Sala[] colSalas = new Sala[5]; // Tamaño de la sala
            colSalas[0] = new Sala(); // Defaut
            colSalas[1] = new Sala(200, "Sala");// Capacidad - opcion 2
            colSalas[2] = new Sala(200, "Sala A");// Capacidad y nombre opcion 3
            colSalas[3] = new Sala(200, "Sala B");
            colSalas[4] = new Sala(200, "Sala C");

            return colSalas;
        }

        public List <Empleado> coleccionEmpleados()
        {
            List<Empleado> coleccionEmpleados = new List<Empleado>();
            Empleado emp1 = new Empleado();// Crear un nuevo empleado
            coleccionEmpleados.Add(emp1);// Agregar el empleado a la lista

            for (int i=1; i<=100; i++)// Para crear vario emplados a la vez
            coleccionEmpleados.Add(new Empleado());//Crea y agrega el empleado

            return coleccionEmpleados;
        }
    }
}
