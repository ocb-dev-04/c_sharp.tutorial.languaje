using System;
using System.Collections.Generic;

namespace _053._list_collections_and_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // puedes instanciar una lista
            List<string> list = new List<string>();
            list.Add("Pablo");
            list.Add("Mario");
            list.Add("Juan");
            list.Add("Luis");

            // puedes inicializarla inmediatamente
            // hagamos esta vez una lista de numeros
            List<int> numeros = new List<int>(){ 5, 6, 7, 98, 26, 359, 54 };
            // y luego puedo seguir agregando numeros
            numeros.Add(4);

            // puedes convertirla en array, obviamnete el array debera ser de lo que tenga la lista
            // en este caso es de string asi que string[] pero si fuera de int pues int[]
            string[] listToArr = list.ToArray();

            // para convertir  a array la lista de numeros pues:
            int[] listInt = numeros.ToArray();

            Console.WriteLine("Con la lista");
            foreach (string nombres in list)
            {
                Console.WriteLine(nombres);
            }

            
            Console.WriteLine("Con el array");
            for (int i = 0; i < listToArr.Length; i++)
            {
                Console.WriteLine(listToArr[i]);
            }

            // asi como podemos agregar tambien podemos limpiar, remover, etc...
            
            // para remover algun registro podemos usar Remove o RemoveAt
            // Remove lo usamos para ser especificos o pasar el valor que qeremos remover
            list.Remove("Mario");
            numeros.Remove(98);
            // RemoveAt o usamos para remover en base a indice, el  indice comienza en 0 como si fuera un array
            list.RemoveAt(0); // remover el elemento de indice 0 osea el primero
            numeros.RemoveAt(4); // remover el elemento de indice 4
            numeros.RemoveAt(numeros.Count - 1);// remover el elemento de ultimo indice

            // si queremos agregar un valor en el medio de la lista en vez de Add usamos Insert:
            list.Insert(1, "Julio"); // insertar ese nombre en el indice 1
            numeros.Insert(5, 9); // insertar  el 9 en el indice 5

            // aunque podemos mostrar la lista completa por medio de un foreach, podemos acceder a elementos especificos
            // de esta forma
            string elementoListaS = list[2];// accedemos al elemento de indice 2
            int elementoListaI = numeros[5];// accedemos al elemento de indice 5

            Console.WriteLine("{0}{1}",elementoListaI, elementoListaS);

            // para limpiar la lista
            list.Clear();
            numeros.Clear();
        }
    }
}
