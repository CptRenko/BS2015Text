using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TngEngine;

namespace BS2015
{
    public class HabitacionIzquierda
    {
        private IA objIa = new IA();
        private Text objText = new Text();

        //Procesar accion de la primera habitación
        public void procesarAccionHabitacionIzq()
        {
            String input;
            String[] validInput = new String[] { "izquierda", "derecha", "centro" };
            bool salir = false;
            do
            {
                Console.WriteLine("---");
                Console.WriteLine("Llegas a la sala de recepción.");
                Console.WriteLine("A tu izquierda hay un sillon y encima esta el cadaver de un cientifico.");
                Console.WriteLine("A tu derecha hay una entrada a una habitación");
                Console.WriteLine("En tu centro hay una mesa, con un PAD sobre el");
                Console.WriteLine("¿A que direccion deseas ir primero?: ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "izquierda":
                        String opcion = "";
                        bool 
                        do
                        {
                            Console.WriteLine("El cadaver posee rastros de asfixia y posee sus 2 manos sobre el cuello.");
                            Console.WriteLine("Hay una carta sobre el, ¿deseas leerlo? (SI/NO)");
                            opcion = Console.ReadLine().ToLower();
                            switch (opcion)
                            {
                                case "si":
                                    Console.WriteLine("---");
                                    Console.WriteLine("5874");
                                    Console.WriteLine("---");
                                    break;
                                case "no":
                                    Console.WriteLine("Volviendo a la sala de recepción");
                                    //salir2 = true;
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida");
                                    //salir2 = true;
                                    break;
                            }
                        }
                        while (opcion != "si" || opcion != "no");
                        break;

                    case "derecha":
                        String[] validInputTwo = new String[] { "izquierda, derecha" };
                        String leerDireccion;
                        Text objText = new Text();
                        do
                        {
                            Console.WriteLine("Habitación de Powers");
                            Console.WriteLine("A la izquierda hay un PC prendido");
                            Console.WriteLine("A la derecha hay un post-it con algo escrito");
                            Console.WriteLine("¿A que direccion deseas ir?");
                            leerDireccion = Console.ReadLine().ToLower();

                            switch (leerDireccion)
                            {
                                case "izquierda":
                                    String pass;
                                    bool crack = false;
                                    int cantErr = 0;
                                    do
                                    {
                                        Console.WriteLine("---");
                                        Console.WriteLine("Bienvenido al sistema de acceso PC-003");
                                        Console.WriteLine("Ingrese su contraseña: ");
                                        pass = Console.ReadLine().ToString();
                                        //Contraseña acceso PC-003
                                        if (pass != "2435")
                                        {
                                            Console.WriteLine("Error!. Contraseña invalida");
                                            ++cantErr;
                                        }

                                        if (cantErr > 2)
                                        {
                                            Console.WriteLine("Se ha detectado varios errores seguidos. Alerta de sistema");
                                            Console.WriteLine("Ingresando a modulo para detectar intruso");
                                            for (int i = 0; i < 5; i++)
                                            {
                                                objText.barraProgreso(i, 10);
                                                Thread.Sleep(1000);
                                            }

                                            crack = objIa.crackearPc003();
                                        }
                                    }
                                    while (pass != "2435" || crack);
                                    break;

                                case "derecha":
                                    break;

                                default:
                                    Console.WriteLine("Zona invalida");
                                    break;
                            }
                        }
                        while (!objIa.validarAcciones(validInputTwo, leerDireccion));
                        break;

                    case "centro":
                        break;

                    default:
                        Console.WriteLine("Error!, zona no valida");
                        break;
                }

            }
            while (!objIa.validarAcciones(validInput, input) || salir);

        }
    }
}
