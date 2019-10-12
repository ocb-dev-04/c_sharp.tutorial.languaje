using System;

namespace _013._if_conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Fulano";
            string phrase = "Esta es una frase normal";

            var longitudName = name.Length;

            Console.WriteLine(longitudName);
            if(longitudName != 6)// si la longitud del nombre es diferente de 6
            {
                Console.WriteLine(phrase.Length);
            }
            else if(longitudName == 6)
            {
                Console.WriteLine("La longitud es 6");
            }
            else // si es igual a 6, entonces
            {
                // se puede ejecutar un if dentro de otro if
                if(longitudName > 10)
                {
                    Console.WriteLine("La longitud es mayr que 10");
                }
            }

        }
    }
}
