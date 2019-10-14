using System;

namespace _032._optionals_arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando el valor por defecto");
            NombreMetodo("John");// solo enviamos el valor del primer parametro
            Console.WriteLine("Pasando todos los valores");
            NombreMetodo("Luis", 42);// ahora enviamos ambos parametros
        }

        // aunque para este ejemplo ponemos por defecto el ultimo valor
        // no signica que no podamos poner por defecto el primero incluso
        // podemos poner por defecto todos los valores
        private static void NombreMetodo(string name, int age = 18)
        {
            Console.WriteLine($"Tu nombre es: {name} y tu edad es: {age}");
        }
    }
}
