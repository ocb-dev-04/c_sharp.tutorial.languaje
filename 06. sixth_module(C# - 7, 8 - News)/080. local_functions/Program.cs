using System;

namespace _080._local_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaramos la funcion interna
            void FuncionLocal()
            {
                Console.WriteLine("funcion interna");

                // declaramos otra funcion local
                void FuncionLocal2()
                {
                    Console.WriteLine("Segunda funcion, dentro de la interna");
                }

                // invocamos la funcion local 2
                FuncionLocal2();

            }

            // invocamos la funcion local
            FuncionLocal();

            // puedes invocar funciones internas antes de su declaracion
            var resultado = Suma(7, 8);


            int Suma(int a, int b)
            {
                return a + b;
            }

            // podemos usar expresiones lambda
            int Multi(int a, int b) => a * b;

            var producto = Multi(4, 5);

        }
    }
}
