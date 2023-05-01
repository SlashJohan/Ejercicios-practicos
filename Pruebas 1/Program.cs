using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite un numero porfavor: ");

            int num = int.Parse(Console.ReadLine());

            // Si el numero es un numero par o impar se divide y el residual si da 0 entonces es un numero par si no es un numero impar

            if ((num % 2) == 0)
            {
                Console.WriteLine("El numero " + num + " Es par.");
            }

            else
            {
                Console.WriteLine("El numero " + num + "Es impar.");
            }
            Console.ReadKey();
        }


    }

}
