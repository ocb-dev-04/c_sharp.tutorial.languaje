using System;
using System.Collections.Generic;

namespace _017._break_and_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // utilizazremos el mismo ejemplo del otro capitulo para que lo veas aplicado en los ciclos
            List<string> names = new List<string>
            {
                "Leonardo",
                "Jose",
                "Francisca"
            };

            #region break examples

            Console.WriteLine("Probando con el while");
            // ciclo while
            //definimos una variable para conteo
            int j = 0;
            while (j < names.Count)
            {
                // digamos que al llegar a Jose quiere que el ciclo se rompa
                if(names[j].Equals("Jose"))// si el nombre es igual a Jose, salte del ciclo
                {
                    Console.WriteLine("El nombree es igual a Jose, asi que me salgo");
                    break;
                }

                Console.WriteLine(names[j]);
                j++;// le aumentamos uno a j
            }

            Console.ReadKey();


            Console.WriteLine("Probando con el do while");
            // definimos una variable de conteo al igual que en el while
            int m = 1;
            // ciclo do while
            do{
                // digamos que quieres probar si la condicion del while es true antes de llegar a el
                if(m == 1)
                {
                    Console.WriteLine("La variable llego al maximo, no se mostrara nada");
                    break;// como es true, rompes el ciclo
                }

                m++;
            }while(m < 1);

            // debes tener muy pendiente el hecho de que el do while ejecuta al menos una vez el codigo,
            // asi que si en algun momento debes acceder a una lista que tiene posibilidades de estar vacia
            // te dara un error
            
            Console.ReadKey();

            Console.WriteLine("Probando con el for");
            // provemos esta vez con un for
            // imprimamos los numeros del 1 al 10 pero rompamos el ciclo cunado vaya por el 8
            for (int i = 1; i < 10; i++)
            {
                if(i==8)// revisas si i llego al numero arbitrario
                {
                    Console.WriteLine(i);// muestras el 8
                    Console.WriteLine("Llego a 8");// avisas que llego hasta el 8
                    break;// sales
                }
                Console.WriteLine(i);
            }
                
            #endregion
        
            #region continue examples
            
            // digamos que no quiere cerrar el ciclo, digamos que solo quieres ignorar un valor

            Console.WriteLine("Probando con el for con el continue");
            // provemos esta vez con un for
            // imprimamos los numeros del 1 al 10 pero ignoramos el 8
            for (int i = 1; i < 10; i++)
            {
                if(i==8)// revisas si i llego al numero arbitrario
                {
                    continue;// haces un continue es como llegar a la ultima linea del ciclo, de manera que no se mostrara el 8
                }
                Console.WriteLine(i);
            }

            // ahora con el foreach mostraremos solo los nombres que comiencen con Jo
            foreach (var name in names)
            {
                if(!name.StartsWith("Jo"))// si el nombre no comienza con Jo
                {
                    continue; // ignoralo
                }

                Console.WriteLine(name);
            }

            #endregion
        
        }
    }
}
