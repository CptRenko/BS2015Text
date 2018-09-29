using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class ClJugador
    {
        private String nombre;
        private int edad;

        public ClJugador(String nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


    }
}
