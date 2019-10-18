using System;
using System.Collections.Generic;

namespace _052._generic_restrictions
{
    class Program
    {
        static void Main(string[] args)
        {
            // los datos estructurados son los primitivos
            Generico_Struct<int>(5);
            // le pasamos como generico y como parametro un gato, ya que es hijo de Animal
            Generico_Herencia<Gato>(new Gato());
        }

        // restriccion para tipo de datos estructurados
        static void Generico_Struct<T>(T value) where T : struct
        {
            Console.WriteLine(value);
        }
        
        // restriccion para clases
        static void Generico_Class<M>() where M : class
        {

        }

        // restriccion para interfaces
        static void Generico_Interface<T>(T implementation) where T : IEnumerable<T>
        {
            foreach (T item in implementation)
            {
                
            }
        }

        // restriccion para constructor
        static C Generico_Constructor<C>() where C : new()
        {
            return new C();
        }

        // restriccion para mas de un tipo
        static void Generico_Dynamic<T>() where T : struct, IEnumerable<T>
        {

        }

        static void Generico_Herencia<A>(A animal) where A : Animal
        {
            animal.HacerRuido();
        }
    }

    abstract class Animal
    {
        public abstract void HacerRuido();
    }

    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Wauff");
        }
    }

    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miua");
        }
    }
    
}
