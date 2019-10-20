using System;

namespace _066._lambda_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // con un solo argumento
            Console.WriteLine("Con un solo argumento");
            Func<int, int> duplicar = x => { return x * 2; };
            Console.WriteLine(duplicar(50));

            // con mas de un argumento
            Console.WriteLine("Con mas de un argumento");
            Func<int, int, int> multi = (x, y) => { return x * y; };
            Console.WriteLine(multi(50, 20));

            Console.ReadKey();
        }
    }
}
