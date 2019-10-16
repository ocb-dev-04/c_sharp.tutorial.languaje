using System;
using System.Collections.Generic;

namespace _051._generics_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // con un solo generico
            ManejoGenSolo<int> classGenSolo = new ManejoGenSolo<int>();
            classGenSolo.Add(56);// como especifique el generico seria entero pues mando entero

            Console.WriteLine("");

            ManejoCRUD<int, string> claseGen  = new ManejoCRUD<int, string>();
            claseGen.Add(5);//en este caso paso el valor de la T que seria un int
            claseGen.Add("Nombre cual sea");// en este caso para el valor de I que es string

            Console.ReadKey();
        }
    }

    // aunque por lo genetal se usa la T puedes darle el valor que quieras
    class ManejoGenSolo<T> 
    {
        public List<T> _entidad { get; set; }
        public ManejoGenSolo()
        {
            _entidad = new List<T>();
        }

        // creamos un metodo para recibir T
        public void Add(T valor)
        {
            _entidad.Add(valor);
            foreach (var valorList in _entidad)
            {
                Console.WriteLine(valorList);
            }
        }

    }

    // hacemos una clase con dos genericos
    class ManejoCRUD<T, I> 
    {
        public List<T, I> _entidad { get; set; }
        public ManejoCRUD()
        {
            _entidad = new List<T, I>();
        }

        // creamos un metodo para recibir T
        public void Add(T valor)
        {
            _entidad.Add(valor);
            foreach (var valorList in _entidad)
            {
                Console.WriteLine(valorList);
            }
        }

        // aprovechamos la sobrecarga de metodos y hacemos el mismo metodo pero para I
        public void Add(I valor)
        {
            _entidad.Add(valor);
            foreach (var valorList in _entidad)
            {
                Console.WriteLine(valorList);
            }
        }
    }
}
