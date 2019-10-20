using System;

namespace _065._predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<Persona> predic = EsMayorDeEdad;
            var p = new Persona()
            {
                Nombre = "fulano",
                Edad = 35
            };

            Console.WriteLine(predic(p));

            Console.ReadKey();
        }

        static bool EsMayorDeEdad(Persona persona)
        {
            return persona.Edad >= 18;
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
