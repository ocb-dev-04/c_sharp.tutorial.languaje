using System;
using System.Linq;
using System.Collections.Generic;

namespace _074._linq_groupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            // agrupar entre pares e impares
            var groups = numeros.GroupBy(x => Math.Abs(x % 2));

            // ahora primero iteramos los grupos, luego los elementos
            foreach (var clase in groups)
            {
                Console.WriteLine("Numeros de residuo {0}", clase.Key);
                foreach (var item in clase)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n");
            }


            // hagamos esto mas interesante
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Name = "Josias", Age = 99, Salary = 25000 },
                new Persona() { Name = "Jose", Age = 35, Salary = 25000 },
                new Persona() { Name = "Mateo", Age = 17, Salary = 15000 },
                new Persona() { Name = "Carlos", Age = 12, Salary = 55000 },
                new Persona() { Name = "Henrrique", Age = 22, Salary = 85000 }
            };

            var groupDePersonas = personas.GroupBy(x =>
            {
                if(x.Age <= 20)
                {
                    return "Menor que 20";
                }
                else if(x.Age >= 21 && x.Age <= 40)
                {
                    return "Entre 21 y 40";
                }
                else 
                {
                    return "Mas de 41";
                }
            });

            foreach (var clase in groupDePersonas)
            {
                Console.WriteLine("Grupo de: {0} --- cantidad: {1}", clase.Key, clase.Count());
                foreach (var item in clase)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("\n");
            }


            Console.ReadKey();
        }
    }

    class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
