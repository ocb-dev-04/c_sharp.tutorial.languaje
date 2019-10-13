using System;
using System.Collections.Generic;

namespace _027._methods
{
    class Program
    {
        // usaremos como base el ejemplo anterior
        static void Main(string[] args)
        {
            // instacio la clase y le envio una lista
            var e1 = new ExampleClass(new List<int>(){ 58,69,75 });
            // instancio la clase por segunda vez y le instancio la segunda lista
            var e2 = new ExampleClass(new List<int>(){ 98,55,-76 });
            // ahor ausando la primera instancia invoco el metodo de suma y le paso la segunda instancia como parametro
            var eSuma = e1.Suma(e2);

            Console.WriteLine("El resultado de la suma de las lista es:");
            foreach (var result in eSuma)
            {
                Console.WriteLine(result);
            }
            
        }
    }

    class ExampleClass
    {
        #region Fields

        // esto es un campo
        // al ser instanciada la clase, esto toma el valor de la lista que se envia
        private List<int> _classVar;// se llena en base al constructor
            
        #endregion
        
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
        // toma el tamano o la dimension de la lista con la cual se instancio la clase
        public int Dimension { get { return _classVar.Count; } }

        #endregion

        #region Construct
    
        // hagamoslo mas interesante, asignemosle un valor al invocar el constructor y luego leamos a que vale
        public ExampleClass(List<int> listInt)
        {
            _classVar = listInt;// le decimos que el campo sera igual a lo enviado al instancia el constructor
        }

        #endregion

        #region Methods
            
        public List<int> Suma(ExampleClass sum)
        {
            /*
            Ojo aqui: es posible que creas que es lo mismo pero no, si llamo la instancia
            ei su dimension es igual a la dimension de la misma instanciai, pero la instancia que envio
            en este caso sum, es la dimension de la otra lista que se instancia luego de la primera
            CUIDADO y no te vayas a confundir

            Asi que primero tomo la dimension de la instancia que invoca el metodo y
            luego la misma propiedad dimension pero de la instancia que envio como parametro
             */
            if(Dimension != sum.Dimension)
            {
                throw new ApplicationException("Las dimensiones no son iguales");
            }

            List<int> result = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                result.Add(this[i] + sum[i]);
            }

            return new List<int>(result);
        }
        #endregion
    }
}
