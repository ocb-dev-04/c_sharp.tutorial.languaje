using System;

namespace _030._methods_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            // mismo nombre diferente tipos y diferente cantidad de parametros
            int sum1 = Sumar(5, 6);
            int sum2 = Sumar(5, 8965.63);
            int sum3 = Sumar(6, 8, 9);
        }

        #region Sobre carga de metodos

        // definimos con el nombre de suma y con dos parametros
        private static int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        // definimos el mismo nombre misma cantidad de parametros pero difiere el tipo
        private static int Sumar(int n1, double n2)
        {
            return n1 + (int)n2;// obviamente hacemos un convert antes de hacer la suma
        }

        // mismo nombre, pero con mas parametros
        private static int Sumar(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
            
        #endregion
    }
}
