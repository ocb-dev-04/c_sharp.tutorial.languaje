using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _067._linq_where
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 8, 7, 9, -45, 568, -48, 26548, -9
            };

            // con wehere evaluaremos cada elemento y si cumple con la condicion 
            // lo vuelve lista y lo almacena en el variable
            
            // todos los elementos que sean mayor que cero
            var result = numeros.Where(x => x > 0).ToList();
            Console.WriteLine("Mayor que cero");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // a la hora de evaluar la expresion booleana podemos hacer mas de una comparacion
            // todos los elementos mayor que cero y que sean divisibles entre 2
            var resultDivisible = numeros.Where(x => x > 0 && x%2 == 0).ToList();
            Console.WriteLine("\n\nMayor que cero y divisible entre 2");
            foreach (var item in resultDivisible)
            {
                Console.WriteLine(item);
            }

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Name = "Jose", Age = 18 },
                new Persona() { Name = "Jorge", Age = 42 },
                new Persona() { Name = "Junior", Age = 40 },
                new Persona() { Name = "Carlos", Age = 19 },
                new Persona() { Name = "Henrrique", Age = 14 }
            };

            // quiero a todos los mayores de edad
            var personasMayores = personas.Where( x => x.Age >= 18).ToList();
            Console.WriteLine("\n\nPersonas mayores de edad");
            foreach (var item in personasMayores)
            {
                Console.WriteLine(item.Name);
            }

            // digamos que haces un buscardor y quieres que retorno toda aquella persona que en su nombre comience con la busqueda establecida
            string nameFind = "JO".ToLower();// convertimos todo a minusculas tanto aqui como al hacer el request
            // busco en personas elementos donde, el nombre empieze con el valor de busqueda, o (||) tenga dentro de el dicho valor
            var buscarPorNombre = personas
                                    .Where(x => 
                                        x.Name.ToLower().StartsWith(nameFind) ||
                                        x.Name.ToLower().Contains(nameFind))
                                    .ToList();

            Console.WriteLine("\n\nPersonas que su nombre comienza o tiene una: {0}", nameFind);
            foreach (var item in buscarPorNombre)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }

    class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
