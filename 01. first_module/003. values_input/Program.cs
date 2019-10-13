using System;

namespace _003._values_input
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeAsk();
        }

        static void MakeAsk()
        {
            string name;
            int age;

            System.Console.Write("Enter your name: ");
            name = Console.ReadLine();

            System.Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            string output = string.Format("Your name is {0} and  your age is {1}", name, age);
            System.Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
