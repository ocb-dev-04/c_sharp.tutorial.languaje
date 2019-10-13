using System;

namespace _023._nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            // primera manera de definir un nullable y la mas larga
            Nullable<int> valueNull = 45;// podemos asignarle valor
            valueNull = null;//y luego podemos asignarle null

            // segunda manera de definir un nullable y la mas corta y PRO
            DateTime? dateNullable = null;// podemos asignarle un null
            dateNullable = new DateTime(2017, 2, 2);// y despues asignarle un valor

            // si quieres saber si un nullable tiene valor pues:
            if(valueNull.HasValue)// si tiene valor
            {
                Console.WriteLine("valueNull posee valor");
            }
            else// sino
            {
                Console.WriteLine("valueNull no posee valor");
            }

            if(dateNullable.HasValue)// si tiene valor
            {
                Console.WriteLine("dateNullable posee valor");
                // no podemos pasar el valor nullable como tal, asi que hacemos uso de su propiedad Value
                // obviamente una ve ya hallamos confirmado que tiene valor
                int valReturn = ShowDate(dateNullable.Value, 55);
                Console.WriteLine(valReturn);
            }
            else// sino
            {
                Console.WriteLine("dateNullable no posee valor");
            }


            int ShowDate(DateTime date, int value)
            {
                Console.WriteLine(date);
                return value;
            }
        }
    }
}
