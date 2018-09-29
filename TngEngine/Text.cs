using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TngEngine
{
    public class Text
    {
        /**
         * Valida que los datos de entrada en un output String sean solo numeros
         * 
         * */
        private Boolean soloNumero(String entrada)
        {
            int num;

            if(int.TryParse(entrada, out num))
            {
                return true;
            }

            return false;
        }

        /**
         * Obtenemos un numero en base  a la entrada de un String
         * String entrada -> Datos a validar
         * bool showMessage -> Mostrar mensaje de error
         * */
        public int obtNum(String entrada, bool showMessage = false)
        {
            int numero = -1;
            if (soloNumero(entrada))
            {
                numero = int.Parse(entrada);
            }

            if (showMessage && !soloNumero(entrada))
            {
                Console.WriteLine("Numero invalido!");
            }

            return numero;
            
        }

        //Dibujar barra de progreso.
        //https://gist.github.com/slashdotdash/169620
        //Modificado por Yisus
        public void barraProgreso(int progreso, int total)
        {
            float tamanoBloque, tamano;
            int position = 1;
            //Determina el tamaño del bloque de color del loading
            tamanoBloque = 30.0f / total;

            //Determinamos el tamaño del bloque
            tamano = tamanoBloque * progreso;

            //int desplazamiento = 3;
            Console.CursorLeft = 0;
            Console.Write("[");
            Console.CursorLeft = 32;
            Console.Write("]");
            Console.CursorLeft = 0;
            //draw filled part
            for (int i = 0; i < tamano; i++ )
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= total; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }
        }
    }
}
