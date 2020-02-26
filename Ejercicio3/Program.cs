using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un dia de la semana");
            String dia = Console.ReadLine();

            switch (dia.ToLower())
            {

                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("El dia que ingreso no es fin de semana");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("El dia que ingreso si es fin de semana");
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese un dia de la semana.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
