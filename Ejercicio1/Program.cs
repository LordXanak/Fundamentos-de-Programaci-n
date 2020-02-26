using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, v3;

            Console.WriteLine("Ingrese un número: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            v3 = int.Parse(Console.ReadLine());
            int suma = v1 + v2 + v3;

            Console.WriteLine("El resultado es " + suma);

            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
