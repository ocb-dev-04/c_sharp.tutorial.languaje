using System;

namespace _086._out_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // intentamos parcear de string a datetime
            if(DateTime.TryParse("2019-04-20", out DateTime fecha))
            {
                // codigo en caso de que  se parsee bien
            }
            else
            {
                // codigo para hacer en caso de que se parsee mal
            }

        }
    }
}
