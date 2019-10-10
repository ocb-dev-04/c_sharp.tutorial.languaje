using System;

namespace _007._operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 8;
            var d = 10;

            Console.WriteLine(a+b);
            Console.WriteLine(d-a);
            Console.WriteLine(c/b);
            Console.WriteLine(d*c+b);

            Console.WriteLine("Increment to c value: ");
            c++;
            Console.WriteLine(c); // show 9
            Console.WriteLine("Decrement to c value: ");
            d--; // decrement
            Console.WriteLine(c); // show 9

            Console.WriteLine("The rest of 15/2 is: ", 15%2);
        }
    }
}
