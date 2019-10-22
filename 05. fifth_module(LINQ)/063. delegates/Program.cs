using System;

namespace _063._delegates
{
    class Program
    {
        // declaramos un delegado el cual pido una funcion o metodo que tome un parametro int y retorno un string
        public delegate string DeEnteroAString(int valor);
        public delegate string ReturnTheCombine(string name, string last);

        static void Main(string[] args)
        {
            // instanciamos el delegado ya que como sabemos es un objeto
            var deEnteroAString = new DeEnteroAString(FuncionRetornaString);
            // instanciamos tambine la que lo retorna pero sumandole uno
            var deEnteroAStringMasUno = new DeEnteroAString(FuncionRetornaStringMas1);

            // mostramos el resultado y obviamente le pasamos los parametros como si fuera al metodo en si
            Console.WriteLine("Mostrando delegados para cambiar a string");
            Console.WriteLine(deEnteroAString(10));
            Console.WriteLine(deEnteroAStringMasUno(10));

            // ahora probamos con delegados de mas de un parametro
            var masDeUnParam = new ReturnTheCombine(MasDeUnParam);
            Console.WriteLine("Mostrando delegados con mas de un parametro");
            Console.WriteLine(masDeUnParam("Fulano", "De tal"));

            Console.WriteLine("Usamos el template para pasar un delegado y un valor");
            // puedes pasarle el delgado que solo lo convierte a string
            Template(deEnteroAString, 40);
            // o puedes pasarle el delegado que suma uno
            Template(deEnteroAStringMasUno, 40);// ya que el delegado en si muestra el valor no necesitamos imprimirlo
            // no puedes enviarle el delegado que pide mas de un parametro ya que te dara error de signature
            // Template(masDeUnParam("Hola", "Que tal"));
        }

        // para delegados de un parametro
        public static string FuncionRetornaString(int valor)
        {
            return valor.ToString();
        }

        public static string FuncionRetornaStringMas1(int valor)
        {
            return (valor + 1).ToString();
        }

        // para delegados de mas de un parametro
        public static string MasDeUnParam(string name, string last)
        {
            return name + " " + last;
        }

        public static void Template(DeEnteroAString algoritmo, int valor)
        {
            Console.WriteLine("Hacer antes del algoritmo");
            Console.WriteLine(algoritmo(valor));
            Console.WriteLine("Hacer despues del algoritmo");
        }
    }
}
