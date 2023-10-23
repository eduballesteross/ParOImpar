using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ParImpar.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int ParOImpar()
        {
            int opcionSeleccionada;

            Console.WriteLine("Introduzca un número entero para comprobar si es par o impar: ");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            if (opcionSeleccionada % 2 == 0)
            {
                Console.WriteLine("El número introducido es par.");
            }
            else
            {
                Console.WriteLine("El número introducido es impar. ");
            }

            return opcionSeleccionada;
        }
    }
}
