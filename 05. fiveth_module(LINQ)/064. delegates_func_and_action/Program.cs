using System;

namespace _064._delegates_func_and_action
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos y asignamos
            Func<int, string> delegadoFunc = FuncionRetornaString;
            // simplemente invocamos
            var resultado = delegadoFunc(45);
            Console.WriteLine("Con Func:");
            Console.WriteLine(resultado);

            Action<int, string>  delegadoAction = SinRetorno;
            Console.WriteLine("Con Action:");
            delegadoAction(56, "Fualno de Tal");


            Action<int, string, decimal, bool>  delegadoActionConMasParametros = MuchosParams;
            Console.WriteLine("Con mas de dos parametros:");
            delegadoActionConMasParametros(22, "Fulanito", 55000, true);

        
        }

        // metodo a llamar
        static string FuncionRetornaString(int valor)
        {
            return valor.ToString();
        }

        static void SinRetorno(int edad, string nombre)
        {
            Console.WriteLine("El nombre es {0} y la edad es: {1}", nombre, edad);
        }

        static void MuchosParams(int edad, string nombre, decimal sueldo, bool soltero)
        {
            if(!soltero)
                Console.WriteLine("Su nombre es {0} y su edad es {1} con un sueldo de {2} y no es soltero", nombre, edad, sueldo);

            Console.WriteLine("Su nombre es {0} y su edad es {1} con un sueldo de {2} y es soltero", nombre, edad, sueldo);
        }
    }
}
