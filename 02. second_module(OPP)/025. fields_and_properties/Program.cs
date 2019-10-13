using System;

namespace _025._fields_and_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new ExampleClass("Este es el mensaje que se mostrara, ya que lo ingreso con la invocacion de la clase");
            Console.WriteLine(e.ClassVar.ToString());
        }
    }

    class ExampleClass
    {
        // esto es un campo
        private string _classVar;

        #region Properties
        
        // esto es una propiedad
        public string classProperty { get; set; }// me deja leer y escribir

        // esto tambien es una propiedad pero configurada para solo lectura
        public string ClassVar 
        { 
            get { return _classVar; } // solo me permite  la lectura y especifico explicitamente que retornara
        }

        #endregion

        #region Construct
    
        // hagamoslo mas interesante, asignemosle un valor al invocar el constructor y luego leamos a que vale
        public ExampleClass(string infoAMostrar)
        {
            _classVar = infoAMostrar;// le decimos que el campo sera igual a lo enviado al instancia el constructor
        }

        #endregion
    }
}
