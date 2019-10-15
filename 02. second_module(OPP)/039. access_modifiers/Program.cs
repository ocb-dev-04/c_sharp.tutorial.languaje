using System;

namespace _039._access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var perro = new Perro();
            // pero  desde la instancia de perro podemos acceder al metodo que lo usa
            perro.AccederAlMetodoProtegido();
            // pero no al metodo en si
            // perro.MetodoProtegido(); // nos da error
        }
    }

    class Animal 
    {
        // declaramos el metodo protected
        protected void MetodoProtegido()
        {
            Console.WriteLine("Este es el metodo protegido");
        }
    }

    class Perro : Animal
    {
        public void AccederAlMetodoProtegido()
        {
            // desde esta clase que la hereda si podemos acceder a el metodo protegido
            MetodoProtegido();
        }
    }
}
