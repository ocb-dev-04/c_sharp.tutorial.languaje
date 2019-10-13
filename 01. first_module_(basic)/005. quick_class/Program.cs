using System;

namespace _005._quick_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Jhon";
            p.Age = 26;
            p.Address = "Charles de Gaulle Av";
            p.ShowInfo();

            Person p2 = new Person();
            p2.Name = "Martin";
            p2.Age = 56;
            p2.Address = "Las Americas Av";
            p2.ShowInfo();

            Console.ReadKey();
        }
        
        class Person 
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }

            public void ShowInfo() 
            {
                string output = "Name is {0}, the age is {1} and the address is {2}";
                output = string.Format(output, Name, Age, Address);
                Console.WriteLine(output);
            }

            // end class
        }

        // end class
    }
}
