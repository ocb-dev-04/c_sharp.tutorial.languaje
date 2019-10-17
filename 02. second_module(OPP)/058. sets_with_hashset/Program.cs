using System;
using System.Collections.Generic;
using System.Linq;

namespace _058._sets_with_hashset
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> conjunto1 = new HashSet<int>();
            conjunto1.Add(5);
            conjunto1.Add(6);


            HashSet<int> conjunto2 = new HashSet<int>();
            conjunto2.Add(5);
            conjunto2.Add(8);


            // podemos hacer algunas cosas con los conjuntos, para esto hare otro conjunto
            // asi los de ejemplo se mantienen iguales
            
            // la union es con todos los elementos sin repetirlos
            HashSet<int> union = new HashSet<int>(conjunto1);// le pasamos conjunto 1 como primer valor
            union.UnionWith(conjunto2);// une todo lo que haya en conjunto 1 y conjunto 2, sin repetir
            
            Console.WriteLine("Union:");
            foreach (var item in union)
            {
                Console.WriteLine(item);// muestra todo
            }

            // la interseccion hace un conjunto con los elementos que se repiten
            HashSet<int> inter = new HashSet<int>(conjunto1);// le pasamos conjunto 1 como primer valor
            inter.IntersectWith(conjunto2);// une todo lo que se repita en ambos conjuntos
            
            Console.WriteLine("\nInterseccion:");
            foreach (var item in inter)
            {
                Console.WriteLine(item);// muestra todo
            }


            //diferencia me muestra todos los valores que son diferentes en los conjuntos
            HashSet<int> dif = new HashSet<int>(conjunto1);// le pasamos conjunto 1 como primer valor
            dif.ExceptWith(conjunto2);// une todo lo que no se repita en el el conjunto 1
            
            Console.WriteLine("\nDiferencia:");
            foreach (var item in dif)
            {
                Console.WriteLine(item);// muestra todo
            }


            // diferencia simetrica
            // me da todos los elemento que no estan en el conjunto contrario
            HashSet<int> difSy = new HashSet<int>(conjunto1);// le pasamos conjunto 1 como primer valor
            difSy.SymmetricExceptWith(conjunto2);// une todo lo que no se repita en el el conjunto 1
            
            Console.WriteLine("\nDiferencia simetrica:");
            foreach (var item in difSy)
            {
                Console.WriteLine(item);// muestra todo
            }


            // llevemos esto a la practica
            
            // definimos una lsita de numeros en la que queremos eliminar los dubplicados
            List<int> numeros = new List<int>(){ 1,2,3,4,4,5,5,5,6,7,8,8,9 };
            // convertimos esa lista a un hashset por medio de un ToList, para utilizar ToList necesitar incluir el using System.Linq.
            numeros = new HashSet<int>(numeros).ToList();
            // de esta manera convertimos el conjutno a lista que es el tipo con el cual definimos a numeros
            // como los conjuntos no permiten valores dubplicados, pues no mostraran los duplicados existentes
            
            Console.WriteLine("Lista de numeros sin repetir");
            foreach (var item in numeros)
            {
                Console.Write(item + " ");
            }



            conjunto2.Clear();

            Console.ReadKey();
        }
    }
}
