using System;
using System.Collections.Generic;

namespace _016._while_and_doWhile_bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Leonardo",
                "Jose",
                "Francisca"
            };

            // ciclo while
            //definimos una variable para conteo
            int j = 0;
            while (j < names.Count)
            {
                Console.WriteLine(names[j]);
                j++;// le aumentamos uno a j
            }

            Console.ReadKey();

            // definimos una variable de conteo al igual que en el while
            int m = 1;
            // ciclo do while
            do{
                Console.WriteLine("Esto se imprime al menos una vez");
                m++;
            }while(m < 1);

            // debes tener muy pendiente el hecho de que el do while ejecuta al menos una vez el codigo,
            // asi que si en algun momento debes acceder a una lista que tiene posibilidades de estar vacia
            // te dara un error
            
            Console.ReadKey();
        }
    }
}
