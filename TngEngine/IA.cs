using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TngEngine
{
    public class IA
    {
        /**
         * Primer puzzle : Crackear la puerta A si no se consigue la contraseña
         * Pasos:
         * - Se consulta por la edad ingresada al comienzo del juego.
         * - Se preunta al jugador a resolver un puzzle matematico-logico.
         * - Se pregunta por el modelo de la IA (titulo del juego)
         * 
         * */
        public void crackearPuertaUno(int edad)
        {
            int vidas = 3;
            int edInput, promInput, promedio;
            Text textEngine = new Text();
            bool crack = false;
            String nombreZona;

            Console.WriteLine("Posee " + vidas + " vidas para este minijuego");
            Console.WriteLine("--");
            do
            {
                //Asignamos valores a las variables
                edInput = promInput = -1;
                nombreZona = "";
                do
                {
                    //Comprobamos estado de vidas
                    if(comprobarVidas(vidas))
                    {
                        Console.WriteLine("Ingrese edad: ");
                        edInput = textEngine.obtNum(Console.ReadLine());

                        if (edInput != edad)
                        {
                            --vidas;
                            Console.WriteLine("Error!, edad no valida. Descontando 1 vida");
                            Console.WriteLine("Le quedan " + vidas);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Presione cualquier tecla para cerrar la aplicación");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                while (edInput != edad);

                Console.WriteLine("Cantidad de vidas restantes: " + vidas);

                //Yisus
                //Primera : 12+12 = 24 ; 24-14 = 10 ; 10+12 = 22 ; 22-14 = 8
                //Segunda : Secuencia de Fibionacci (el numero sucesor es la suma de los 2 anteriores)
                //Tercera : 1 ; (1+1)*1 ; (2+1)*2 ; (3+1)*3 ; (4+1)*4 ; (5+1)*5
                //X = 22 ; Y = 21 ; Z = 42
                Console.WriteLine("De las siguientes secuencias numericas: ");
                Console.WriteLine("1) 12-24-10-22-8-X");
                Console.WriteLine("2) 1-1-2-3-5-8-13-Y");
                Console.WriteLine("3) 1-2-6-12-20-30-Z");
                promedio = (22 + 21 + 42) / 3;

                do
                {
                    if(comprobarVidas(vidas))
                    {
                        Console.WriteLine("Ingrese el promedio de X+Y+Z");
                        promInput = textEngine.obtNum(Console.ReadLine());

                        if (promedio != promInput)
                        {
                            --vidas;
                            Console.WriteLine("Error!, promedio no valido. Descontando 1 vida");
                            Console.WriteLine("Le quedan " + vidas);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Presione cualquier tecla para cerrar la aplicación");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                while (promInput != promedio);

                Console.WriteLine("Cantidad de vidas restantes: " +vidas);

                do
                {
                    if (comprobarVidas(vidas))
                    {
                        Console.WriteLine("Ingrese el modelo IA de la zona: ");
                        nombreZona = Console.ReadLine();

                        if (nombreZona != "BS-2015")
                        {
                            --vidas;
                            Console.WriteLine("ERROR!, Promedio incorrecto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("Presione cualquier tecla para cerrar la aplicación");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                while (nombreZona != "BS-2015");

                //Llegados a este punto se han resueltos los 3 acertijos
                Console.WriteLine("Acceso desbloqueado");
                crack = true;
            }
            while (!crack);
        }

        /**
         * Segundo puzzle
         * 
         * Crackear PC-003
         * 
         **/
        public bool crackearPc003()
        {
            Console.WriteLine("Iniciando sistema de hackeo...");

            return true;
        }

        //Comprobar estado actual de vidas del jugador
        public bool comprobarVidas(int vidas)
        {
            if(vidas > 0)
            {
                return true;
            }

            return false;
        }

        //Comprobar que las acciones por el jugador sean validas
        public bool validarAcciones(String[] validInput, String input)
        {
            int largeArray = validInput.Length;
            for(int i = 0; i < largeArray; i++)
            {
                if(validInput[i].Equals(input))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
