using System;
using System.Text;

namespace _061._two_dimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // podemos definir un arreglo
            int[,] matrizA = new int[2, 2];

            matrizA[0, 0] = 1;
            matrizA[0, 1] = 2;
            matrizA[1, 0] = 3;
            matrizA[1, 1] = 4;

            // o podemos inicializarlo automaticamente
            int[,] matrizB = new int[2, 2]
            {
                {1,2},
                {3,4}
            };

            // ambas matrices son las mismas pero definidas de formas distintas


            // podemos crearlo con las dimensiones que queramos
            string[,] matrizC = new string[3, 2]
            {
                {"valor1", "valor2" },
                {"valor3", "valor4" },
                {"valor5", "valor6" }
            };

            // para iterar un arreglo debemos hacer algo de codigo extra incluyendo un for, fijate:
            IterarArray<string>(matrizC);



        }

        // por medio de los genericos podemos hacer un metodo que  reciba cualquier tipo de arreglo bidimencional
        public static void IterarArray<T>(T[,] matriz)
        {
            // primeros obtenemos el tamano de las filas, como es de dos dimensiones pues [0, 1] => 0
            var filas = matriz.GetLength(0);    
            // luego el tamano de las columnas [0, 1] => 1
            var columnas = matriz.GetLength(1);
            // usamos  string builder para ir creando una cadena mientras se va iterando
            var sb = new  StringBuilder();
            var tmpFila = new T[matriz.GetLength(1)];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpFila[j] = matriz[i, j];
                }

                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }

            Console.WriteLine(sb.ToString());
        }

    }
}
