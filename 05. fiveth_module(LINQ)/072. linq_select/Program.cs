using System;
using System.Linq;
using System.Collections.Generic;

namespace _072._linq_select
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>
            {
                3, 53, 48, 2, 47, 58, 69, 22
            };

            // el tipo de var sera int, pues en si es el tipo del elemento
            var numero = numeros.FirstOrDefault(x => x % 2 == 0);

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Name = "Josias", Age = 18, Salary = 25000 },
                new Persona() { Name = "Jose", Age = 42, Salary = 25000 },
                new Persona() { Name = "Mateo", Age = 17, Salary = 15000 },
                new Persona() { Name = "Carlos", Age = 19, Salary = 55000 },
                new Persona() { Name = "Henrrique", Age = 14, Salary = 85000 }
            };

            // si hacemos una consulta a una entidad el tipo sera la entidad
            var nombre = personas.FirstOrDefault(x => x.Age < 18);
            Console.WriteLine(nombre.Name);// al momento de mostrar la informacion tenemos que acceder a la propiedad Name pues es un tipo de entidad
            //para evitar esto podriamos hacer esto
            var nombreBad = personas.FirstOrDefault(x => x.Age < 18).Name;
            // pero hacerlo asi es poco practico y para nada profesional

            // podemos ahorrarnos eso con select
            var justName = personas
                            .Where(x => x.Age < 18)// hacemos la condicion para el filtrado
                            .Select(x => x.Name)// indicamos que propiedad queremos, como nombre es string, nuestro tipo sera string
                            .FirstOrDefault();// y seleccionamos el primer elemento que cumple con el filtro

            Console.WriteLine("Usando el select con FirstOrDefault");
            Console.WriteLine(justName);

            // tambien puedes usarslo para listas
            var justNameList = personas
                                .Where(x => x.Age < 18)// hacemos la condicion para el filtrado
                                .Select(x => x.Name)// indicamos que propiedad queremos, como nombre es string, nuestro tipo sera string
                                .ToList();
            
            Console.WriteLine("Usando el select para tomar listas");
            foreach (var item in justNameList)
            {
                Console.WriteLine(item);
            }

            // el problema es que a veces no solo necesitas una propiedad sino varias, y no puedes hacer otra expresion lambda asi que ahi entran las proyecciones
            var proyecciones = personas
                                .Where(x => x.Age < 18)// hacemos la condicion para el filtrado
                                .Select(x => new Persona(){ Name = x.Name, Age = x.Age })// creamos una nueva persona la cual tendra el nombre y la edad
                                .FirstOrDefault();// y seleccionamos el primer elemento que cumple con el filtro

            Console.WriteLine("Usando el select con proyecciones de entidad");
            Console.WriteLine("El nombre es {0} y la edad es: {1}",proyecciones.Name, proyecciones.Age);// pero seguiriamos en lo mismo, deberiamos acceder 
            // a cada propiedad sin mencionar que los campos a los que no asignemos nada apareceran como vacios, null o igual a 0

            // por tanto recurrimos a anonimos
            var proyeccionesAnonimas = personas
                                        .Where(x => x.Age < 18)// hacemos la condicion para el filtrado
                                        .Select(x => new { Name = x.Name, Age = x.Age })// creamos una nueva persona la cual tendra el nombre y la edad
                                        .FirstOrDefault();// y seleccionamos el primer elemento que cumple con el filtro

            Console.WriteLine("Usando el select con proyecciones y anonimos");
            Console.WriteLine("El nombre es {0} y la edad es: {1}", proyeccionesAnonimas.Name, proyeccionesAnonimas.Age);
            // si notas debemos acceder a las propiedades al igual que las entidades pero, en este caso el proceso no pesara tanto como si de la entidad se tratara
            // es mas que obvio decir que si usas el tolist en la consulta pues de retorna una lista de todas las coincidencias en formato de tipo anonimo


            // OJO, OJO, OJO, OJO, OJO, OJO, OJO, OJO

            /*
            Algo apra recordar, por lo general select se usa para tomar una propiedad en especifico sea un id, nombre, sueldo etc...
            Hicimos estos ejemplos para darte a ver todo lo que puedes hacer con ella
            */
        }
    }

    class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
