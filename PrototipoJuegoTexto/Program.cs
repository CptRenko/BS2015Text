using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelos;
using TngEngine;
using BS2015;

namespace PrototipoJuegoTexto
{
    class Program
    {
        private static HabitacionIzquierda objHabIzq = new HabitacionIzquierda();

        static void Main(string[] args)
        {
            String nombJugador;
            int edad = -1;
            Text textEngine = new Text();
            IA iaEngine = new IA();
            bool bloqUno, bloqDos;
            bloqUno = bloqDos = false;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("- TRACK GAMES CITT DUOC UC PRESENTA");
            Console.WriteLine("- DESARROLLADO POR TNGSTUDIOS");
            Console.WriteLine("- BS-2015 (PROTOTIPO EXPERIMENTAL)");
            Console.WriteLine("--------------------------------------");

            Console.Write("Ingrese su nombre: ");
            nombJugador = Console.ReadLine();

            Console.WriteLine();

            do
            {
                Console.Write("Ingrese su edad: ");
                edad = textEngine.obtNum(Console.ReadLine(), true);
            }
            while (edad == -1);

            ClJugador jugador = new ClJugador(nombJugador, edad);

            Console.WriteLine();

            Console.WriteLine("Ingeniero " + jugador.Nombre + ":");
            Console.WriteLine("Ha ocurrido un problema en el modulo 3 y debes dirigirte inmediatamente a ese lugar");
            Console.WriteLine("Segun nuestros informes, la IA BS-2015 ha tomado posesion de la zona, ha cortado el oxigeno del lugar y matado a todo el equipo que se encontraba en la zona ");
            Console.WriteLine("Debes ir allí y apagar la maquina");
            Console.WriteLine("Buena suerte");

            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine();

            String zona;
            Boolean salir = false;

            do
            {
                Console.WriteLine("Bienvenido a modulo 3: zona de experimentacion con IA");
                Console.WriteLine("--");
                Console.WriteLine("1.- A la izquierda se encuentra el lugar de recepcion");
                Console.WriteLine("2.- Al centro se encuentra la zona de Investigación y desarrollo");
                Console.WriteLine("3.- A la derecha se encuentra la zona de instalación fisica de la IA");
                Console.Write("Ingrese a que direccion desea ir: ");

                zona = Console.ReadLine().ToLower();

                switch (zona)
                {
                    case "izquierda":

                        int opt = -1;
                        int cant = 1;
                        Console.WriteLine();
                        Console.WriteLine("--USUARIO NO IDENTIFICADO DETECTADO--");
                        Console.WriteLine("--ACCESO CANCELADO--");

                        do
                        {
                            Console.WriteLine("--FAVOR INGRESE SU CONTRASEÑA--: ");
                            opt = int.Parse(Console.ReadLine());
                            Console.WriteLine("Contraseña incorrecta!");

                            //@TODO : Agregar contraseña correcta

                            if(cant >= 2)
                            {
                                Console.WriteLine("Ingrese 2 para intentar crackear la contraseña");
                                opt = int.Parse(Console.ReadLine());
                            }

                            if (cant >= 2 && opt == 2)
                            {
                                iaEngine.crackearPuertaUno(edad);
                                objHabIzq.procesarAccionHabitacionIzq();
                            }
                            else
                            {
                                ++cant;
                            }

                            
                        }
                        while (opt == -1 || cant < 3);
                        break;

                    case "centro":

                        break;

                    case "derecha":
                        if(bloqUno && bloqDos)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Acceso denegado");
                        }
                        break;

                    default:
                        Console.WriteLine("Zona invalida!");
                        break;
                }
            }
            while (!salir);

        }
    }
}
