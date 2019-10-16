using System;
using System.Collections.Generic;

namespace _050._generics_to_introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 5, 6, 89, 57, 630 };

            List<Persona> personas = new List<Persona>() 
            {
                new Persona() { Nombre = "Fulano" },
                new Persona() { Nombre = "Fulanito" }
            };

            //  si te fijas, lista pudes definirla con enteros con tipos de clases y no te da error
            // por la simple razon de que esta creada para aceptar genericos, osea, recibe un tipo de dato
            // y se comporta dependiendo del dato recibido
        }

        private int Duplicar(int valor)
        {
            return valor * 2;
        }
    }

    // esto aqui debajo es solo de ejemplo
    class Persona
    {
        public string Nombre { get; set; }
    }

    class Empresa
    {
        public string Nombre { get; set; }
    }
}
