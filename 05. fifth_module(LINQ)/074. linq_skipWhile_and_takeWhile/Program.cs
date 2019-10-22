using System;
using System.Linq;
using System.Collections.Generic;

namespace _074._linq_skipWhile_and_takeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            // el problema de las consultas con where es que retorna todos los que cumplen con la condicion
            var numero = numeros.Where(x => x < 6).ToList();
            Console.WriteLine("Mostrando con el where");
            foreach (var item in numero)
            {
                Console.WriteLine(item);
            }

            // usemos takeWhile para que veas la diferencia
            var takeW = numeros.TakeWhile(x => x < 6).ToList();
            // lo qu ele decimos es:
            // examina la lista, hasta donde cumplan con la condicion, cuando no se cumpla te paras ahi y me traes los que hasta ese momento la cumplieron
            Console.WriteLine("Mostrando con el takeWhile");
            foreach (var item in takeW)
            {
                Console.WriteLine(item);
            }

            // pero asi como tomamos podemos ignorar en base a una condicon
            var skipW = numeros.SkipWhile(x => x < 6).ToList();
            // lo que le decimos es:
            // examina la lista, hasta donde cumplan con la condicion, cuando no se cumpla te paras ahi  
            // ignora los que hasta ese momento la cumplieron y traeme los que quedan
            Console.WriteLine("Mostrando con el skipWhile");
            foreach (var item in skipW)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
