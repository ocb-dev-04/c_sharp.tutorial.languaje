using System;
using System.Linq;
using System.Collections.Generic;

namespace _071._linq_first_ad_firstOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>
            {
                3, 53, 48, 2, 47, 58, 69, 22
            };

            // traeme el primer elemento
            var primerElement = numeros.FirstOrDefault();
            Console.WriteLine("Primer elemento por defecto:");
            Console.WriteLine(primerElement);
            // el first hace los mismo, pero si no encuentra elemento lanza una exception
            var primerElementFirst = numeros.First();
            Console.WriteLine("Primer elemento o exception:");
            Console.WriteLine(primerElementFirst);

            // aplicando delegados podemos hacer algunas expresiones lambda para hacerlo mas especifico
            // buscar el primero elemento par de la lista
            var primerElementoPar = numeros.FirstOrDefault(x => x % 2 == 0);
            Console.WriteLine("Primer elemento divisible entre 2:");
            Console.WriteLine(primerElementoPar);
            // hacemos esto mismo con el first
            var primerElementoParFirst = numeros.First(x => x % 2 == 0);
            Console.WriteLine("Primer elemento divisible entre 2 o excepcion:");
            Console.WriteLine(primerElementoParFirst);

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Name = "Josias", Age = 18, Salary = 25000 },
                new Persona() { Name = "Jose", Age = 42, Salary = 25000 },
                new Persona() { Name = "Mateo", Age = 17, Salary = 15000 },
                new Persona() { Name = "Carlos", Age = 19, Salary = 55000 },
                new Persona() { Name = "Henrrique", Age = 14, Salary = 85000 }
            };

            // quiero la primera persona que sea menor de edad
            var menorEdad = personas.FirstOrDefault(x => x.Age < 18);
            Console.WriteLine("Primera persona que sea menor de edad");
            Console.WriteLine(menorEdad.Name);

            Console.ReadKey();
        }

        class Persona
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Salary { get; set; }
        }
    }
}
