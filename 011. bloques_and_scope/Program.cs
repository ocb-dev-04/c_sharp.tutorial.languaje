using System;

namespace _011._bloques_and_scope
{
    class Program
    {
        static void Main(string[] args)
        {
            // puedo acceder a esta variable en todo este bloque de codigo del metodo main
            string name = "jon";

            var p = new Person();
            // mediante la instancia puedo acceder a las propiedades y metodos publicos
            p.lastName = "Santos";
            p.PublicMethod();

            // pero no puedo acceder a las propiedades y metodos privados
            // p.Age = 55;// da error ya que el m odificador de acceso no me permite acceder a ella
        }

        // no puedo acceder a name desde aqui ya que sta fuera de bloque
        // name = "Carl";

        public void Main2() 
        {
            // aunque no me muestre error, dara error a la hora de compilar, ya que en este metodo no e definido una variable de nombre name
            // y no puedo acceder desde aqui a la variable definida en el Main
            name = "Jessica";
        }

        class Person// la clase de declara tal cual porque la usaremos en el mismo archivo, si fuera una clase exportada, hayq que definirla como public para poder acceder a ella
        {
            public string lastName { get; set; }
            private int Age { get; set; }

            private void PrivateMethod()
            {
                Console.WriteLine("Output from private method");
            }

            public void PublicMethod()
            {
                Console.WriteLine("Output from public method");
            }
        }
    }
}
