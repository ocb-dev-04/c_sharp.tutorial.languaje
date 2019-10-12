using System;
using System.Collections.Generic;

namespace _015._foreach_bucle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Jhon",
                "Carlos",
                "Maria",
                "Lisbeth",
                "Lisandro"
            };

            foreach (var name in names)
            {
                string addName = "";
                // se pueden hacer comparaciones dentro de el
                if(name.StartsWith("Lis"))// si el nombre comienza con Lis se le agrega el apellido definido
                    addName = " De Jesus Lopez";

                // si intentamos modificar la variable de iteracion, en este caso name, nos dara error
                // name += " contenido extra";

                Console.WriteLine(name + addName);// en caso de que necesitamos agregarle algo, debe ser en otro proceso o pasarlo como parametro a un metodo, pero nunca modificarlo
            }
            // algo bueno de este ciclo es que si la lista no tiene elementos simplemente no ejecuta y sigue las instrucciones no da error ni nada

            Console.ReadKey();
        }
    }
}
