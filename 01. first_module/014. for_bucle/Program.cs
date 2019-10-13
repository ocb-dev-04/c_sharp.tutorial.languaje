using System;
using System.Collections.Generic;

namespace _014._for_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // mostrar numeros del 1 al 10
            // for(valor_de_inicio; valor_maximo; cantidad_a_sumar)
            for(int i = 1; i<= 10; i++)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();

            // mostrar los numeros de un numero inicial hasta un numero final ingresado por el usuario
            int ni, nf;
            Console.Write("Ingresa el numero de inicio: ");
            ni = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el numero final: ");
            nf = Convert.ToInt32(Console.ReadLine());

            for(int i = ni; i <= nf; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            // leer arreglos, listas y tipos dimensionales
            List<string> names = new List<string>()
            {
                "Jhon",
                "Carlos",
                "Maria",
                "Lisbeth"
            };

            // el index de la lista esta desde 0, de manera que debes hacer la comparacion < que el count total de la lista
            // count en las listas sirve como el length para los string y arrays
            // de manera que < names.Count
            // o puedes hacer < names.Count - 1, pero ese menos uno pues, no es muy necesario
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
