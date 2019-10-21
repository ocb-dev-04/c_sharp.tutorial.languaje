using System;
using System.Linq;
using System.Collections.Generic;

namespace _073._linq_skip_and_take
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            // digamos que quiero los primeros dos elementos
            var numero = numeros.Take(2).ToList();
            Console.WriteLine("Mostrando los dos primeros elementos con el take");
            foreach (var item in numero)
            {
                Console.WriteLine(item);
            }

            // quiero ignorar los primeros dos y tomar los 3 primeros a partir de esos dos
            var ignoreAndTake = numeros.Skip(2).Take(3).ToList();
            Console.WriteLine("Mostrando los tres primeros elementos con el take luego del skip");
            foreach (var item in ignoreAndTake)
            {
                Console.WriteLine(item);
            }

            // filtrar los mayores de 4, de estos ignorar dos y seleccionar 3
            var filtrarAndTake = numeros
                                    .Where(x => x > 4)// el where hace una nueva lista con los elemento que cumplen la condicion
                                    .Skip(2)// ignoro lo dos primeros de la nueva lista
                                    .Take(3)// tomo los tres que le siguen
                                    .ToList();// convierto a lista ya que retorna mas de un elemento

            Console.WriteLine("Mostrando los tres primeros elementos con el take luego del skip");
            foreach (var item in filtrarAndTake)
            {
                Console.WriteLine(item);
            }

            /*
            como pudiste darte cuenta, estas instructivas se pueden usar para la paginacion de los request
             */

            Console.ReadKey();
        }
    }
}
