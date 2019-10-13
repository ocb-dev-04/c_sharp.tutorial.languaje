using System;

namespace _006._types_inferency
{
    class Program
    {
        static void Main(string[] args)
        {
            // the var take the type what you assign
            var name = "Jhon";
            var age = 54;
            var endProcess = true;

            // this is an error, can't define a inference var without assign a value
            // var oldAge;

            // also you can use for intance a class, for example:
            var p = new Person();
            p.Age = 55;
        }

        class Person {
            public int Age { get; set; }
        }
    }
}
