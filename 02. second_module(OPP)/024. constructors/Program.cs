using System;
using System.Collections.Generic;

namespace _024._constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> studentNotes = new List<int>()
            {
                86, 70, 95, 84, 75, 99, 97, 89
            };
            // var e = new Example();
            var eE = new Example(studentNotes);
        }
    }

    class Example
    {
        // si instanciamos la clase con un contructor vacio ejecutara el por defecto
        public Example()
        {
            Console.WriteLine("Constructor por defecto");
        }

        // si al instanciar la clase le pasamos una lista de entero pues ejecutara este
        public Example(List<int> intList)
        {
            // incluyo este codigo aqui solo para ejemplo, los contructores no se usan con ese objetivo
            // se usan para inicializazr variables, hacer algun request para una api key o algo
            // o para asignar algun valor externo que se usara al invocar algun metodo solo eso
            // rara vez pasa de 5 lineas de codigo
            Console.WriteLine("Las calificaciones son: \n");
            foreach (var numbers in intList)
            {
                Console.WriteLine(numbers);
            }
            
            float acumulador = 0;
            for (int i = 0; i < intList.Count; i++)
            {
                acumulador += intList[i];
            }
            Console.WriteLine("El promedio es: {0}", acumulador / intList.Count);

        }
    }
}
