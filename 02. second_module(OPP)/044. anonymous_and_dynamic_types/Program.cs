using System;
using System.Collections.Generic;

namespace _045._anonymous_and_dynamic_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // definimos un anonimo
            var anonimos1 = new {nombre = "Fulano",apellido = "De tal",edad = 56,tamano = 1.85};
            var anonimos2 = new {nombre = "Fulano Dos",apellido = "De tal palo",edad = 86,tamano = 1.96};

            // creamos una lista de dinamicos
            List<dynamic> anonimosList = new List<dynamic>();
            // anadimos el anonimo  creado anteriormente
            anonimosList.Add(anonimos1);
            anonimosList.Add(anonimos2);

            foreach(dynamic anon in anonimosList)
            {
                // pero como el tipo esta creado por nosotros, debemos especificar cada cosa
                Console.WriteLine(
                    "El nombre es: {0} y su apellido es: {1}. Tiene {2} anos. Y mide: {3}cm",
                    anon.nombre, anon.apellido, anon.edad, anon.tamano);
            }

            Console.ReadKey();
        }
    }
}
