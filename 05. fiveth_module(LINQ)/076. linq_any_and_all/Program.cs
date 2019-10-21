using System;
using System.Linq;
using System.Collections.Generic;

namespace _075._linq_any_and_all
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros1 = new List<int>
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            List<int> numeros2 = new List<int>
            {
                2, 4, 8, 16, 32, 64
            };

            // All examina que todos cumplan con la condicion dada
            var sonParesTodos1 = numeros1.All(x => x % 2 == 0);// false
            var sonParesTodos2 = numeros2.All(x => x % 2 == 0);// true

            // Any examina si al menos uno cumple con la condicion
            var existeAlgunImpar = numeros1.Any(x => x % 2 == 0);// true
            var mayorQue100 = numeros1.Any(x => x > 1000);// false



            Console.ReadKey();
        }
    }
}
