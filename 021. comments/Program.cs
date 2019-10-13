using System;
using System.ClaseAparte;

namespace _021._comments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // al ir escribiendo el nombre de la clase se vera la descripcion
            var otherProgram = new OtherProgram();
            // al ir escribiendo el nombre del metodo se vera la descripcion
            otherProgram.MethodName();

        }
    }
}

namespace ClaseAparte
{
    /// <sumary>
    /// Este es un ejemplo de la descripcion de una clase. Y ahora le agrego algo mas.
    /// </sumary>
    class OtherProgram
    {
        /// <sumary>
        /// Este es un ejemplo de la descripcion de un metodo. Y ahora le agrego algo mas.
        /// </sumary>
        public void MethodName()
        {
            Console.WriteLine("Algo para mostrar");
        }
    }
}
