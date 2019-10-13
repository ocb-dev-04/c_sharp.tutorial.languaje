using System;

namespace var_declare_and_initilize
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declaration
            // if declare a type cannot assign other type later
            int age;
            char vocal;
            string name;
            DateTime dateNow;
            bool isDay;

            // initializing
            age = 22;                   // integer no need '' or ""
            vocal = 'a';                // char assign just one character inside ''
            name = "Jhon";              // string support world or phrases
            dateNow = DateTime.Now;     // date assign DateTime value
            isDay = true;               // accept just true or false no more

            // can declare and initilize at same time
            int days = 10;
            string first = "Jose";

            // NOTE: if you see a green or orange line under the variables this mean that not use this varaibles
            // not is an error but, just is a sintaxis helper

            // can declare and assign multiple variables
            string 
                    firstName = "Tommy", 
                    lastName = "Smith", 
                    direcction = "Malibub, California";

            Console.WriteLine($"{firstName} {lastName} life in {direcction}");

            Console.ReadKey();
        }
    }
}
