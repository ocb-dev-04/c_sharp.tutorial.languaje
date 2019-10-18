using System;
using System.Collections.Generic;

namespace _055._dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> NombreEdad = new Dictionary<string, int>();
            NombreEdad.Add("Fulano", 56);
            NombreEdad.Add("Jose", 82);
            NombreEdad.Add("Napoleon", 25);

            // para mostrar el valor en consola solo pones el nombre del diccionario y la llave del valor que quieres
            Console.WriteLine(NombreEdad["Fulano"]);

            // puedes hacer diccioanrios con tecnicamente cualquier tipo, ejemplo:
            Dictionary<int, Persona> personas = new Dictionary<int, Persona>();
            personas.Add(4, new Persona(){Nombre = "Fulano", Apellido = "Perencejo"});
            
            // podemos acceder a todas las llaves con Keys
            foreach (var keys in NombreEdad.Keys)
            {
                Console.Write(keys + " - ");//en caso de que queramos la llave en si
                Console.WriteLine(NombreEdad[keys]);// en caso de que queramos los valores de esa llave   
            }


            // si no estamos seguro que una key exista pues
            if(NombreEdad.ContainsKey("Ramon"))// si existe una key con el nombre ramon
                Console.WriteLine(NombreEdad["Ramon"]);// lo mostramos

            // si quieres remover, y al igual que al mostrar no esta seguro de que existe pues
            if(NombreEdad.ContainsKey("Jose"))// si la key de nombre Jose existe
                NombreEdad.Remove("Jose");// la removemos


            // tambien puedes limpiar
            NombreEdad.Clear();
            personas.Clear();
            
            Console.ReadKey();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
