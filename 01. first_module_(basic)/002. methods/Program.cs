using System;

namespace _002._methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // invoque the method
            WriteHelloWord();
            WriteSomething("This is the string to write in console");
            IdentityMethodName("string value", 22, true);
            int val1 = 5, val2 = 6, resultado;
            resultado = AddTwoNumbers(val1, val2);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
// void not return nothing, if wanna return something, need to define the type (int, decimal, string, bool)
        static void WriteHelloWord()
        {
            Console.WriteLine("Hello World!");
        }

        static void WriteSomething(string some)
        {
            Console.WriteLine(some);
        }

        // method with more params
        static void IdentificateMethodName(string value1, int value2, bool value3)
        {
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
        }

        static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
