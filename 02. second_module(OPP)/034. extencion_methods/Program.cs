using System;

namespace _034._extencion_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 5;
            Console.WriteLine(age.Potencia(2));
            float ageF = age;// para usar el metodo destinado a float debes definirla previamente como float, no puedes hacer una conversion explicita o implicita
            Console.WriteLine(ageF.Division(5));
        }
    }

    public static class DoubleExtensionMethods
    {
        // este metodo es para integers, se le agreag el sumary que ya lo hemos visto anteriormente para dar mas detalles acerca de lo que hace
        ///<sumary>
        /// Este metodo permite calcular la potencia del numero dado.
        ///</sumary>
        public static double Potencia(this int value, int potencia)
        {
            return Math.Pow(value, potencia);
        }

        // este metodo es para doubles
        public static double Division(this float value, int dividendo)
        {
            return value / dividendo;
        }
    }
}
