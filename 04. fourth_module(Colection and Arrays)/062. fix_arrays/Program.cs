using System;
using System.Text;

namespace _062._fix_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // definimos el arreglo de arreglos y el 2 dentro de corchete define la cantidad de arreglos que podra contener
            int[][] jaggedArray = new int[2][];
            // le asignamos al arreglo numero 1 que su tamano sera de 4 indices
            jaggedArray[0] = new int[4];
            // llenamos el arreglo numero 1 por eso el primer corchete tiene el 0, osea primer
            jaggedArray[0][0] = 6;
            jaggedArray[0][1] = -3;
            jaggedArray[0][2] = 9;
            jaggedArray[0][3] = -150;

            // ahora le asignamos al segundo arreglos un tamano directamente en la inicializacion
            jaggedArray[1] = new int[]
            {
                15,6,3,2,6,7,8, -100
            };

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                // vamos almacenando todo lo del arreglo en un string
                // se creara un string por arreglo
                var join = string.Join(",",jaggedArray[i]);
                Console.WriteLine(join);
            }

            Console.ReadKey();
        }
    }
}
