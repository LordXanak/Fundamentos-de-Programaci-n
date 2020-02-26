using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre");
            String nombre = Console.ReadLine();
 
            Console.WriteLine("Escriba su edad");
            String edad = Console.ReadLine();

           

            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años");

            Console.ReadLine();

        }
    }
}
