using System;

namespace _081._igualation_pattern__is_
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 55;

            // verificamos si es del tipo necesario
            if(edad is int edadRef)// si edad es int guardame su valor en edadRef
            {
                edadRef = 60;
                Console.WriteLine("El valor si es un entero");
            }
            else
            {
                // sino, se ejecuta el codigo de aqui
                Console.WriteLine("El valor no es entero");
            }
            

            Console.ReadKey();
        }
    }
}
