using System;
using System.Linq;
using System.Collections.Generic;

namespace _078._linq_agregate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                1, 2, 3, 4, 5, 86, 45, 2, 1, 78, 9
            };

            // ira multiplicando de dos en dos
            var producto = numeros.Aggregate((an, ac) => an * ac);
            Console.WriteLine("El total de la multiplicacion de los numeros es: {0}", producto);
            // esto funciona asi:
            /*
            1 * 2 = 2
            2 * 3 = 6
            6 * 4 = 24
            24 * 5 = 120
            120 * 86 = .... y asi sucesivamente
             */

            // hagamos esto mas interesante
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Name = "Josias", Age = 99, Salary = 25000 },
                new Persona() { Name = "Jose", Age = 35, Salary = 25000 },
                new Persona() { Name = "Mateo", Age = 17, Salary = 15000 },
                new Persona() { Name = "Carlos", Age = 12, Salary = 55000 },
                new Persona() { Name = "Henrrique", Age = 22, Salary = 85000 }
            };

            // quieror el total de la multiplicacion de las edades
            // primero creamos una lista con todas las edades
            var allEdadSimple = personas.Select(x => x.Age);
            // y entonces sacamos el producto
            var edadProductSimple = allEdadSimple.Aggregate((an, ac) => an * ac);
            Console.WriteLine("El producto de las edades optenido de manera simple es: {0}", edadProductSimple);

            // pero te puedes ahorrar tantas consultas con solo agregar una detras de otra, asi:
            var allEdadCompuesta = personas
                                    .Select(x => x.Age)
                                    .Aggregate((an, ac) => an * ac);

            Console.WriteLine("El producto de las edades optenido de manera compuesta es: {0}", allEdadCompuesta);

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
