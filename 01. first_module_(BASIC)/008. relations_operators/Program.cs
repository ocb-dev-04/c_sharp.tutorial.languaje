using System;

namespace _008._relations_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2;
            var b = 6;
            var c = 8;
            var d = 65;

            bool result = c == d;
            Console.WriteLine("c == d is {0}", result);// igual to
            result = c != d;
            Console.WriteLine("c != d is {0}", result);// diferent to
            result =  a < b;
            Console.WriteLine("a < b is {0}", result); // lees to
            result = a > b;
            Console.WriteLine("a > b is {0}", result); // higher to
            result = c <= d;
            Console.WriteLine("c <= d is {0}", result);// lees or igual to
            result = c >= d;
            Console.WriteLine("c >= d is {0}", result);// higher or igual to

            result = a is string;
            Console.WriteLine("a is a string is {0}", result); // is a string?
            result = a is int;
            Console.WriteLine("b is a int is {0}", result);// is a int?
            
            Console.ReadKey();
        }
    }
}
