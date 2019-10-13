using System;
using System.Collections.Generic;

namespace _026._index
{
    class Program
    {
        // usaremos como base el ejemplo anterior
        static void Main(string[] args)
        {
            var e = new ExampleClass(new List<int>(){ 58,69,75 });
            Console.WriteLine(e[2]);// mostramos el valor que ocupa el index 2 en este caso el 75
            e[1] = 89;// modificamos el 69 del index 1 por el 89
            Console.WriteLine(e[1]); // mostrar el 89 recien asignado
        }
    }

    class ExampleClass
    {
        // esto es un campo
        private List<int> _classVar;// se llena en base al constructor

        #region Properties
        
        // definimos el indexador, el tipo del index debe ser igual al valor que va a retornar
        public int this[int i] 
        { 
            get
            {
                return _classVar[i]; // retornara el valor del index enviado
            } 
            set
            {
                _classVar[i] = value; // agregara el valor enviado en el index indicado
            }
        }
        
        #endregion

        #region Construct
    
        // hagamoslo mas interesante, asignemosle un valor al invocar el constructor y luego leamos a que vale
        public ExampleClass(List<int> listInt)
        {
            _classVar = listInt;// le decimos que el campo sera igual a lo enviado al instancia el constructor
        }

        #endregion
    }
}
