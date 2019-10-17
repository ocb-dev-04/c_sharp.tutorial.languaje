using System;

namespace _059._array_introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicilizacion basica
            int[] arrNumeros = new int[4];
            arrNumeros[0] = 5;
            arrNumeros[1] = 45;
            arrNumeros[2] = 7;
            arrNumeros[3] = 9;

            Console.WriteLine("El tamano del arreglo de numero es de {0}", arrNumeros.Length);

            // inicializacion directa
            string[] arrCadena = new string[] { "Fulano", "Fulanito", "Perencejo", "Futanejo", "Maria", "Jose" };
            
            Console.WriteLine("El tamano del arreglo de cadenas es de {0}", arrCadena.Length);

            // para recorrerlo usamos for
            Console.WriteLine("Mostrando array de numeros: ");
            for (int i = 0; i < arrNumeros.Length; i++)
            {
                Console.WriteLine(arrNumeros[i]);
            }

            Console.WriteLine("Mostrando array de cadenas: ");
            for (int i = 0; i < arrCadena.Length; i++)
            {
                Console.WriteLine(arrCadena[i]);
            }

            // para redimencionar un arreglo solo usa esto
            Array.Resize<int>(ref arrNumeros, 50);// ahora el arreglo arrNumeros tiene como indice 50
            Array.Resize<string>(ref arrCadena, 20);// ahora el arreglo cadena tiene un indice de 20

            Console.WriteLine("El tamano del arreglo de numero despues de redimencionado es de {0}", arrNumeros.Length);
            Console.WriteLine("El tamano del arreglo de cadena despues de redimencionado es de {0}", arrCadena.Length);

            Console.ReadKey();
        }
    }
}
