using System;
using System.Collections.Generic;

namespace _037._inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacemos la lista de Animal (la clase padre) de esta manera nos permitira a;adir vaca, 
            // oveja o cualquier clase hija, esto de usar clases derivadas en base a clases padres se le denomina
            // polimorfismo, en los siguientes capitulos hablaremos de eso
            List<Animal> animals = new List<Animal>();
            animals.Add(new Vaca("Manchas"));
            animals.Add(new Oveja("Pelusa"));
            animals.Add(new Perro("Firulais"));

            foreach (var animal in animals)
            {
                // fijate que como en vaca hicimos un override al metodo de hacer ruido, se ejecutara ese, pero a oveja ni siquiera lo sdefinimos, 
                // asi que se ejecutara el por defecto
                animal.HacerRuido();
            }

            Console.ReadKey();
        }
    }

    // clase padre
    class Animal 
    {
        public string Nombre { get; set; }

        public virtual void HacerRuido()
        {
            Console.WriteLine("{0} hace ruido", Nombre);
        }
    }

    // clases hijas
    class Vaca : Animal
    {
        public Vaca(string nombre)
        {
            Nombre = nombre;
        }

        public override void HacerRuido()
        {
            Console.WriteLine("{0} dice muuu", Nombre);
        }
    }

    class Oveja : Animal
    {
        public Oveja(string nombre)
        {
            Nombre = nombre;
        }

        // comentamos este metodo, para que se ejecute el por defecto
        // public override void HacerRuido()
        // {
        //     Console.WriteLine("{0} dice veee", Nombre);
        // }
    }

    class Perro : Animal
    {
        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        public override void HacerRuido()
        {
            Console.WriteLine("{0} dice jau, jau", Nombre);
        }
    }
}
