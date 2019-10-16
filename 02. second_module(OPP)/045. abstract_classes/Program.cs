using System;

namespace _046._abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // puedes declarar de tipo clase padre y asignarle una calse hijo
            Animal perro = new Perro();
            Animal vaca = new Vaca();
            Animal oveja = new Oveja();
            
            // o puedes definirla totalmente como una clase hijo y aun asi lo aceptara
            Oveja ovejaO = new Oveja();

            // dado que Animal es una clase abstracta no podemos instanciarla
            // var animal = new Animal(); // nos da error

            AnimalHaceRuido(perro);
            AnimalHaceRuido(vaca);
            AnimalHaceRuido(oveja);// como la oveja no tiene un override para el sonido, muestra el rudio generico
            AnimalHaceRuido(ovejaO);

            Console.ReadKey();
        }

        public static void AnimalHaceRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }

    // clase padre
    abstract class Animal 
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido generico");
        }
    }

    // clases hijas
    class Vaca : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Dice muuu");
        }
    }

    class Oveja : Animal
    {
        // la oveja usara el ruido generico
    }

    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Dice jau, jau");
        }
    }
}
