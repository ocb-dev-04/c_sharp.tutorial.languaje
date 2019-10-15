using System;

namespace _034._extencion_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 5;
            Console.WriteLine(age.Potencia(2.5));
            float ageF = age;// para usar el metodo destinado a float debes definirla previamente como float, no puedes hacer una conversion explicita o implicita
            Console.WriteLine(ageF.Division(5));
            string stringCount = "Esta es la cadena de ejemplo";
            Console.WriteLine(stringCount.StringCount());// usando el metodo de extension
            Console.WriteLine(stringCount.Length);// usando el metodo por defecto de C#
        }
    }

    public static class DoubleExtensionMethods
    {
        // este metodo es para integers, se le agreag el sumary que ya lo hemos visto anteriormente para dar mas detalles acerca de lo que hace
        ///<sumary>
        /// Calcular la potencia del numero dado.
        ///</sumary>
        public static double Potencia(this int value, double potencia)
        {
            return Math.Pow(value, potencia);
        }

        // este metodo es para doubles
        ///<sumary>
        /// Retorna la division de el valor con el que es invocado entre el valor agregado..
        ///</sumary>
        public static double Division(this float value, int dividendo)
        {
            return value / dividendo;
        }

        // este metodo es para string, nos retornara el total de caracteres
        ///<sumary>
        /// Retorna el total de caracteres que contiene una cadena.
        ///</sumary>
        public static int StringCount(this string value)
        {
            return value.Length;// obviamente C# tiene una propiedad para acceder a la longitud de una cadena pero era para darte un ejemplo
        }
    }
}
