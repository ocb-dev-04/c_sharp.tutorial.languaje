using System;
using System.Collections.Generic;

namespace _056._firstIn_firstOut_with_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            Console.WriteLine("Primer elemento agregado");
            Console.WriteLine("Juan");
            queue.Enqueue("Juan");

            Console.WriteLine("Segundo elemento agregado");
            Console.WriteLine("Pedro");
            queue.Enqueue("Pedro");

            Console.WriteLine("Tercer elemento agregado");
            Console.WriteLine("Marcos");
            queue.Enqueue("Marcos");

            Console.WriteLine("Mostrando con el foreach");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // pasamos de queue a array
            string[] queueString = queue.ToArray();
            // accedemos al total de queue creados
            int queueCount = queue.Count;

            Console.WriteLine("Mostrando con el for y arrays");
            for (int i = 0; i < queueCount; i++)
            {
                // accedemos a cada valor por medio de su index
                Console.WriteLine(queueString[i]);
            }


            Console.WriteLine("");

            // ahora a vaciarlo, en si lo que hace es sacar el valor y traertelo
            Console.WriteLine("Sacando primer elemento");
            var elementosQueue = queue.Dequeue();
            Console.WriteLine(elementosQueue);

            Console.WriteLine("Sacando segundo elemento");
            elementosQueue = queue.Dequeue();
            Console.WriteLine(elementosQueue);

            Console.WriteLine("Sacando tercer elemento");
            elementosQueue = queue.Dequeue();
            Console.WriteLine(elementosQueue);

            // limpiamos el Queue
            queue.Clear();

        }
    }
}
