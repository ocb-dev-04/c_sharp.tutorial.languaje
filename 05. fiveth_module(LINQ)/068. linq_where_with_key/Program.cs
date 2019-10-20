using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _068._linq_where_with_key
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 8, 7, 9, -45, 568, -48, 26548, -9, 56
            };
            
            // todos los elementos que sean mayor que 18 y su indice sea divisible entre 2
            var result = numeros.Where((x, indice) => x > 18 && indice % 2 == 0).ToList();
            Console.WriteLine("Elementos con indices divisibles entre 2");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
