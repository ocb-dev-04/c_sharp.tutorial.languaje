using System;
using System.Linq;
using System.Collections.Generic;

namespace _070._linq_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>
            {
                3, 56, 48, 2, 47, 58, 69, 22
            };

            // te permite reversar una lista
            Console.WriteLine("Mostrando lista al reves");
            numeros.Reverse();// no le asignamos nada a nadie ya que esto es una instruccion para un listado en si, osea los cambios son directos
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            // pero tambien puedes definir los indices que quieres que se reviertan
            // digamos que quiero que los extremos queden iguales pero los del medio se cambien, pues:
            List<int> numeros2 = new List<int>
            {
                3, 56, 48, 2, 47, 58, 69, 22
            };

            Console.WriteLine("Mostrando lista al reves en base a indices");
            numeros2.Reverse(1,numeros2.Count - 2);// que empiece en el indice 1 y que termine antes del ultimo asi el ultimo no se le aplica
            foreach (var item in numeros2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
