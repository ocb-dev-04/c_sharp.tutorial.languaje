using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _069._linq_orderBy_and_thenBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 8, 7, 9, -45, 568, -48, 26548, -9, 59
            };
            
            // todos los elementos que sean positivos y ordenarlos
            var ascendente = numeros
                                .Where(x => x > 0)
                                .OrderBy(x => x)// ordenamos en base al valor en si del elemento
                                .ToList();
            
            var descendente = numeros
                                .Where(x => x > 0)
                                .OrderByDescending(x => x)// ordenamos en base al valor en si del elemento
                                .ToList();

            Console.WriteLine("\n\nElementos positivos ordenados de forma ascendente!!");
            foreach (var item in ascendente)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nElementos positivos ordenados de forma descendente!!");
            foreach (var item in descendente)
            {
                Console.WriteLine(item);
            }


            // con una simple lista de numero no parece tener mucho sentido lo del ascending y descending, veamoslo con una clase
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Name = "Josias", Age = 18, Salary = 25000 },
                new Persona() { Name = "Jose", Age = 42, Salary = 25000 },
                new Persona() { Name = "Mateo", Age = 40, Salary = 15000 },
                new Persona() { Name = "Carlos", Age = 19, Salary = 55000 },
                new Persona() { Name = "Henrrique", Age = 14, Salary = 85000 }
            };

            // ordenar la lisra por nombre en orden (alfabetico obviamente)
            // si notas el where lo usamos para filtrar, asi que aqui no es necesario, solo necesitamos ordenar no filtrar nada
            var ordernarAsc = personas.OrderBy(x => x.Name).ToList();
            // ordenamos de forma descendente
            var ordernarDesc = personas.OrderByDescending(x => x.Name).ToList();

            Console.WriteLine("\n\nOrdenar nombres ascendentes:");
            foreach (var item in ordernarAsc)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\n\nOrdenar nombres descendientes:");
            foreach (var item in ordernarDesc)
            {
                Console.WriteLine(item.Name);
            }

            var edadAsc = personas.OrderBy(x => x.Age).ToList();
            // ordenamos de forma descendente
            var edadDesc = personas.OrderByDescending(x => x.Age).ToList();

            Console.WriteLine("\n\nOrdenar edades ascendentes:");
            foreach (var item in edadAsc)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\n\nOrdenar edades descendientes:");
            foreach (var item in edadDesc)
            {
                Console.WriteLine(item.Name);
            }
        
            // imagina que quieres ordenar por salario, pero tambien por nombre
            // para esto usamos ThenBy, no es mas que al ordenar una lista sigue ordenando
            // en base al resultado de la primera, osea:
            var orderSalary = personas.OrderBy(x => x.Salary)// ordenamos por salario
                                      .ThenBy(x => x.Name)// y en base a ese orden, entonces ordenamos por nombres
                                      .ToList();

            Console.WriteLine("\n\nOrdenar por salario teniendo en cuenta el orden de nombres:");
            foreach (var item in orderSalary)
            {
                Console.WriteLine("El sueldo es {0} y su nombre es {1}", item.Salary, item.Name);
            }


        }
    }
    
    class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }

}
