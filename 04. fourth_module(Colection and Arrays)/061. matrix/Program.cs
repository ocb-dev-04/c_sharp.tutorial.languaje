using System;
using System.Text;

namespace _061._matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matrizA = new Matriz(2, 2);
            matrizA[0, 0] = 5;
            matrizA[0, 1] = 6;
            matrizA[1, 0] = 8;
            matrizA[1, 1] = 1;

            Matriz matrizB = new Matriz(2, 2);
            matrizB[0, 0] = 3;
            matrizB[0, 1] = 2;
            matrizB[1, 0] = 9;
            matrizB[1, 1] = 7;

            Matriz matrizSuma = matrizA + matrizB;

            Console.WriteLine("La matriz A es:");
            Console.WriteLine(matrizA.ToString());

            Console.WriteLine("La matriz B es:");
            Console.WriteLine(matrizB.ToString());

            Console.WriteLine("La matriz resultante es:");
            Console.WriteLine(matrizSuma.ToString());

            Console.ReadKey();
        }
    }

    class Matriz
    {
        #region Fields

        private int[,] _data;
            
        #endregion

        #region Properties

        // indexador
        public int this[int fila,  int columna]
        {
            get{
                return _data[fila, columna];
            }
            set{
                _data[fila, columna] = value;
            }
        }

        // para saber el tamano de las filas y columnas, se accede a estas por medio de la instancia de la clase en si
        public int Filas { get{ return _data.GetLength(0); } }
        public int Columnas { get{ return _data.GetLength(1); } }

        #endregion

        #region Construct
            
        public Matriz(int filas, int columnas)
        {
            _data = new int[filas, columnas];
        }

        #endregion

        #region Methods

        public static Matriz operator +(Matriz a, Matriz b)
        {
            // confirma si las filas y columnas de ambas matrices son iguales
            if(a.Filas != b.Filas || a.Columnas != b.Columnas)
                throw new ApplicationException("Las matrices deben ser de la misma dimension");

            // creaamos una matriz de resultado
            Matriz c = new Matriz(a.Filas, a.Columnas);

            for (int i = 0; i < a.Filas; i++)
            {
                for (int j = 0; j < a.Columnas; j++)
                {
                    // le asignamos la suma de ambos valores a la misma coordenada de la matriz resultado
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }

        // reescribimos el metodo ToSting para que en este caso nos devuelva la lectura de la matriz
        public override string ToString()
        {
            var sb = new StringBuilder();
            var tmpFila = new int[Columnas];
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    tmpFila[j] = this[i, j];
                }

                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }

            return sb.ToString();
        }
            
        #endregion    
    }
}
