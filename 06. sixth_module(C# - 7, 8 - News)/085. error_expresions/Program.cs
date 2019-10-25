using System;

namespace _085._error_expresions
{
    class Program
    {
        static void Main(string[] args)
        {
            // si el divisor no es cero se divide, si lo es, pues se lanza la excepcion
            double Dividir(double a, double b) 
                => (b != 0) ? a / b : throw new ApplicationException("Denominador no puede ser 0");

            var c = Dividir(1, 4);
            var d = Dividir(5, 0);

            Console.ReadKey();
        }
    }
}
