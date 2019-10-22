using System;
using System.Linq;
using System.Collections.Generic;

namespace _076._linq_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                1,2,3,4,5
            };

            // hacer una suma de todos los elemento de la coleccion numeros
            var suma = numeros.Sum();


            // hagamos esto mas interesante
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Name = "Josias", Age = 99, Salary = 25000 },
                new Persona() { Name = "Jose", Age = 35, Salary = 25000 },
                new Persona() { Name = "Mateo", Age = 17, Salary = 15000 },
                new Persona() { Name = "Carlos", Age = 12, Salary = 55000 },
                new Persona() { Name = "Henrrique", Age = 22, Salary = 85000 }
            };

            // suma total de todos los salarios
            var totalSalario = personas.Sum(x => x.Salary);// obviamente no podemos dejar sum tal cual, ya que C# no sabe como sumar las entidades, por lo tanto le instanciamos la propiedad que queremos sumar
            // hacemos lo mismo con la edad
            var totalEdad = personas.Sum(x => x.Age);

            // podemos sumar cualquier tipo "numerico" (int, double, decimal, float, etc...)

            // tambien podemos definir tipos anonimos y llenarlo con informacion: Ejemplo:
            var personasInfo = new {
                TotalSalary = personas.Sum(x => x.Salary),
                TotalAge = personas.Sum(x => x.Age)
            };


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
