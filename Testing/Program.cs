using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TngEngine;
using BS2015;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            IA objIa = new IA();
            HabitacionIzquierda objGame = new HabitacionIzquierda();
            //objIa.rand();
            //objIa.procesarAccionHabitacionIzq();
            objGame.procesarAccionHabitacionIzq();
            Console.ReadLine();
        }
    }
}
