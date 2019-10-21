using System;
using System.Linq;
using System.Collections.Generic;

namespace _077._linq_min_max_average
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                1, 2, 3, 4, 5, 86, 45, 2, 1, 78, 9
            };

            var min = numeros.Min();
            var max = numeros.Max();
            var average = numeros.Average();

            Console.WriteLine("El valor minimo es: {0} el valor maximo es: {1} y el promedio es: {2}", min, max, average);

            // hagamos esto mas interesante
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Name = "Josias", Age = 99, Salary = 25000 },
                new Persona() { Name = "Jose", Age = 35, Salary = 25000 },
                new Persona() { Name = "Mateo", Age = 17, Salary = 15000 },
                new Persona() { Name = "Carlos", Age = 12, Salary = 55000 },
                new Persona() { Name = "Henrrique", Age = 22, Salary = 85000 }
            };

            var edadMinima = personas.Min(x => x.Age);
            var sueldoMaximo = personas.Max(x => x.Salary);
            var promedioEdad = personas.Average(x => x.Age);
            Console.WriteLine("La edad menor es: {0} el promedio de edad es: {1} y el salario maximo es: {2}", edadMinima, promedioEdad, sueldoMaximo);


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
