using System;

namespace _049._ref_vs_out
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona(){ Nombre = "Quien sea" };

            Console.WriteLine("-- Tipo de referencia --");
            Console.WriteLine("Previo al cambio");
            Console.WriteLine(persona.Nombre);
            EditarPersona(persona, "Fulano");// cambiamos el valor por
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(persona.Nombre);

            Console.WriteLine("");

            Console.WriteLine("-- Tipo de valor --");
            Console.WriteLine("Previo al cambio");
            int edad = 9;
            Console.WriteLine(edad);
            EditarEdad(edad, 14);// cambiamos el valor por
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(edad);

            Console.WriteLine("");

            Console.WriteLine("-- Tipo de valor con ref --");
            Console.WriteLine("Previo al cambio");
            int edadRef = 9;
            Console.WriteLine(edadRef);
            EditarEdadRef(ref edadRef, 14);// cambiamos el valor por
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(edadRef);

            Console.WriteLine("");

            Console.WriteLine("-- Tipo de valor con out --");
            Console.WriteLine("Previo al cambio");
            int edadOut;// en caso de out no es necesario inicializarla
            // Console.WriteLine(edadOut);
            EditarEdadOut(out edadOut, 14);// cambiamos el valor por
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(edadOut);


            Console.ReadKey();
        }
        static void EditarPersona(Persona persona, string nuevoNombre)
        {
            persona.Nombre = nuevoNombre;
        }
    
        // sin el ref
        static void EditarEdad(int edadActual, int nuevaEdad)
        {
            edadActual = nuevaEdad;
        }    

        // con el ref
        static void EditarEdadRef(ref int edadActual, int nuevaEdad)
        {
            edadActual = nuevaEdad;
        } 

        // con el out
        static void EditarEdadOut(out int edadActual, int nuevaEdad)
        {
            edadActual = nuevaEdad;
        } 
    
    }

    class Persona
    {
        public string Nombre { get; set; }
    }
}
