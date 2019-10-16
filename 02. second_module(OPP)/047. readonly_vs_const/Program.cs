using System;

namespace _048._readonly_vs_const
{
    class Program
    {
        // constante
        const double PI = 3.14;
        // no puedes asignarle un valor por referencia
        // const double PI_referencia = RepositorioValores.PI;// esto da erro

        // readonly
        readonly double PI_2 = 3.14;
        // si puedes asignarle valor d referencica
        readonly double PI_2_referencia = RepositorioValores.PI;// si te permite asignarlo
        
        static void Main(string[] args)
        {
            
        }
    }

    static class RepositorioValores
    {
        public static double PI = 3.14;
    }

    // en caso que uses clases no estaticas, puedes asignarle valor desde el contructor
    class TestReadOnly
    {
        // declaramos
        protected readonly string _cadenaReadOnly;
        public TestReadOnly(string readonlyValue)
        {
            _cadenaReadOnly = readonlyValue;// asignamos
        }
    }
}
