using System;
using System.Collections.Generic;

namespace _057._lastIn_firstOut_with_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            Console.WriteLine("Primer string agregado");
            Console.WriteLine("Jorge");
            stack.Push("Jorge");

            Console.WriteLine("Segundo string agregado");
            Console.WriteLine("Luis");
            stack.Push("Luis");

            Console.WriteLine("Tercer string agregado");
            Console.WriteLine("Carlos");
            stack.Push("Carlos");

            Console.WriteLine("Mostrando con foreach");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //puedes saber cuantos hay ingresados
            int stackCount = stack.Count;
            // y convertirlo en arreglo
            string[] stackArr = stack.ToArray();

            Console.WriteLine("Mostrando con for despues de pasarlo a  Array");
            for (int i = 0; i < stackArr.Length; i++)
            {
                Console.WriteLine(stackArr[i]);
            }

            if(stack.Contains("Jorge"))
                Console.WriteLine("El estack si posee a {0}","Jorge");

            // para sacarlos entonces
            Console.WriteLine("Sacando tercer elemento");
            var stackRe = stack.Pop();
            Console.WriteLine(stackRe);

            Console.WriteLine("Sacando segundo elemento");
            stackRe = stack.Pop();
            Console.WriteLine(stackRe);

            Console.WriteLine("Sacando primer elemento");
            stackRe = stack.Pop();
            Console.WriteLine(stackRe);

            Console.WriteLine("");

            // se limpia el stack
            stack.Clear();
            

            Console.ReadKey();

        }
    }
}
