using System;

namespace _031._params
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 56.36;
            double n2 = 5656.36;
            double n3 = 896.36;
            double result = Calculate(n1, n2, n3, 5, 56, 89, 30);
            Console.WriteLine(result);
        }

        // al usar params nos evitamos hacer muchos metodos con diferentes parametros
        private static double Calculate(params double[] nums)// ojo que el tipo de dato que se espera es de tipo array, por eso no importa la cantidad de parametros que envies
        {
            double sumt = 0;
            foreach (var number in nums)
            {
                sumt += number;
            }

            return sumt / nums.Length;

        }
    }
}
