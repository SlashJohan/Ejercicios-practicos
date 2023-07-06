using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Pruebas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Numeros primos
            //Console.WriteLine("Digite un numero porfavor: ");

            //int num = int.Parse(Console.ReadLine());

            //// Si el numero es un numero par o impar se divide y el residual si da 0 entonces es un numero par si no es un numero impar

            //if ((num % 2) == 0)
            //{
            //    Console.WriteLine("El numero " + num + " Es par.");
            //}

            //else
            //{
            //    Console.WriteLine("El numero " + num + " Es impar.");
            //}

            //Console.ReadKey();

            #endregion

            #region Dias de la semana

            //Console.WriteLine("Por favor digite un numero de la semana: ");

            //int numMes = int.Parse(Console.ReadLine());

            //switch (numMes)
            //{
            //    case 1:
            //        Console.WriteLine("Dia de la semnana escogido: Lunes");
            //        break;

            //    case 2:
            //        Console.WriteLine("Dia de la semnana escogido: Martes");
            //        break;

            //    case 3:
            //        Console.WriteLine("Dia de la semnana escogido: Miercoles");
            //        break;

            //    case 4:
            //        Console.WriteLine("Dia de la semnana escogido: Jueves");
            //        break;

            //    case 5:
            //        Console.WriteLine("Dia de la semnana escogido: Viernes");
            //        break;

            //    case 6:
            //        Console.WriteLine("Dia de la semnana escogido: Sabado");
            //        break;

            //    case 7:
            //        Console.WriteLine("Dia de la semnana escogido: Domingo");
            //        break;
            //}
            //Console.ReadKey();
            #endregion

            #region Tablas de multiplicar

            //Console.WriteLine("Por favor indique que tabla de multiplicar desea obtener informacion.");

            //int NumTablaMulti = int.Parse(Console.ReadLine());

            //Console.WriteLine("Tabla de Multiplicar del numero " + NumTablaMulti + ":");

            //for (int i = 1; i <= 10; i++)
            //{
            //    int resultado = NumTablaMulti * i;
            //    Console.WriteLine(NumTablaMulti + " x " + i + " = " + resultado);
            //}

            //Console.ReadKey();

            #endregion

            #region Nombres y edades

            //string[] nombres = new string[5];
            //int[] edades = new int[5];

            ////Carga de datos por teclado

            ///**for (int i = 0; i < nombres.Length; i++)*/
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Ingrese el nombre de la Persona #{0}:", i + 1);
            //    nombres[i] = Console.ReadLine();

            //    Console.WriteLine("Ingrese la edad de {0}:", nombres[i]);
            //    edades[i] = int.Parse(Console.ReadLine());
            //}
            //// Impresion de nombres de personas mayores de edad
            //Console.WriteLine("Personas mayores de edad:");

            ///**for (int i = 0; i < nombres.Length; i++)*/
            //for (int i = 0; i < 5; i++)
            //{
            //    if (edades[i] >= 18)
            //    {
            //        Console.WriteLine(nombres[i]);
            //    }
            //}

            //Console.ReadKey();

            #endregion

            #region Numeros primos con numero statico

            //int num = 22;

            ////Si el numero es un numero par o impar se divide y el residual si da 0 entonces es un numero par si no es un numero impar

            //if ((num % 2) == 0)
            //{
            //    Console.WriteLine("El numero " + num + " Es par.");
            //}

            //else
            //{
            //    Console.WriteLine("El numero " + num + " Es impar.");
            //}

            //Console.ReadKey();

            #endregion

            #region Cohete a la luna
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine("Listos para el despegue en #{0}:", i);
            //}
            //Console.WriteLine("Despegue" + ".......");

            //Console.ReadKey();
            #endregion

            #region Un for o foreach que recorre un array

            //int[] numeros = {1,2,3,4,5,6,7,8,9};
            //foreach (int i in numeros)
            //{
            //   Console.WriteLine(i);
            //}

            //Console.ReadKey();

            #endregion

            #region Cohete a la luna 2 con condicion diferente en el for y en orden ascendente

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Listos para el despegue en #{0}:", i);
            //}
            //Console.WriteLine("Despegue" + ".......");

            //Console.ReadKey();

            #endregion

            #region Recorre los numero de 1 a 100 y imprime indicando cuales son los pares y los impares
                
            //for(int i = 1; i <= 100; i++)
            //{
            //      if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} es un numero par");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} es un numero impar");
            //    }
                    
            //    Console.ReadKey();
            //}
                
            #endregion

        }
    }
}
