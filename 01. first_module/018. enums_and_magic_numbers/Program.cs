using System;

namespace _018._enums_and_magic_numbers
{
    class Program
    {
        // obviamnte si vas a usar un enum desde otro archivo debes declararlo como public
        // public enum NombreEnum {
        //      nombre_constante = valor_constante
        //}
        enum OpStatus 
        {
            Succesful = 1,
            ClientNotFound = 2,
            InternError = 5
        };

        static void Main(string[] args)
        {
            int statusResult = 5;

            #region enums example

            // poniendo el (int) delante de la "variable o constante" la parseamos a int, se puede usar (double)(string) etc...
            if(statusResult == (int)OpStatus.Succesful)
            {
                Console.WriteLine("El estado es exitoso");
            }else if(statusResult == (int)OpStatus.ClientNotFound)
            {
                Console.WriteLine("El estado es cliente no encontrado");
            }else if(statusResult == (int)OpStatus.InternError)
            {
                Console.WriteLine("El estado es error interno");
            }
                
            #endregion
        
            #region magic numbers

            /*
            Quizas en el momento en el que hagas el codigo, te acuerdas que valen esos numeros (1, 2, 3), pero unos meses despues, o 
            una persona que no seas tu se le volvera un caos la cabeza para saber que es eso. 
            
            Por ende para evitar eso usamos enum
            */
            if(statusResult == 1)
            {
                Console.WriteLine("El estado es exitoso");
            }else if(statusResult == 2)
            {
                Console.WriteLine("El estado es cliente no encontrado");
            }else if(statusResult == 3)
            {
                Console.WriteLine("El estado es error interno");
            }
                
            #endregion
        }
    }
}
