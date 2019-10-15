using System;

namespace _035._static_class_and_members
{
    class Program
    {
        static void Main(string[] args)
        {
            // para acceder a los metodos de una clase statica no se necesita instanciarla, solo escribes el nombre de la clase seguido del nombre del metodo
            Matematicas.Suma(5, 9);

            // si intentamos acceder al metodo resta no podemos, ya que no es estatico
            // Resta(4, 9);

            //asi que accedemos desde la clase padre instanciandola, asi:
            var p = new Program();
            // y ahora si tenemos acceso a ese metodo
            int rest = p.Resta(4, 9);

            // ahora accedamos a un metodo estatico que esta en una clase no estatica
            // no hay que crear una instancia, solo usamos el nombre como si de una clase estatica se tratase
            Factura.DividirEntrePi(5);

            Console.ReadKey();
        }

        public int Resta(int val1,  int val2)
        {
            return val1 - val2;
        }
    }

    // la clase estatica matematicas no tienen ninguna propiedad que depedenda de lectura o escritura externa
    static class Matematicas 
    {
        const double PI = 3.14;

        public static int Suma(int value1, int value2)
        {
            return value1 + value2;
        }

        public static double AreaDelCirculo(float radio)
        {
            return radio * radio * PI;
        }
    }

    // la clase factura si tiene propiedades que segun su instancia tendras valores diferentes
    class Factura
    {
        public int Id { get; set; }
        public string Client { get; set; }

        public static double DividirEntrePi(double divisor)
        {
            return divisor / 3.14;
        }
    }
}
