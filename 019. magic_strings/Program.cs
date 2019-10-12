using System;

namespace _019._magic_strings
{
    class Program
    {
        // obviamnte si vas a usar el enum desde otro archivo pues declaralo publico
        enum StringEnum 
        {
            Succesful = "ERR_04",
            ClientNotFound = "ERR_05",
            InternError = "ERR_06"
        };
        
        static void Main(string[] args)
        {
            string statusResult = "ERR_06";

            #region magic strings 

            // al igual que con los numeros fuera de contexto, pasa igual con los string

            if(statusResult.Equals("ERR_04"))
            {
                Console.WriteLine("El estado es exitoso");
            }else if(statusResult.Equals("ERR_05"))
            {
                Console.WriteLine("El estado es cliente no encontrado");
            }else if(statusResult.Equals("ERR_06"))
            {
                Console.WriteLine("El estado es error interno");
            }

            #endregion

            #region enums example

            //para evitar eso usamos enums

            // poniendo el (int) delante de la "variable o constante" la parseamos a int, se puede usar (double)(string) etc...
            if(statusResult.Equals(StringEnum.Succesful))
            {
                Console.WriteLine("El estado es exitoso");
            }else if(statusResult.Equals(StringEnum.ClientNotFound))
            {
                Console.WriteLine("El estado es cliente no encontrado");
            }else if(statusResult.Equals(StringEnum.InternError))
            {
                Console.WriteLine("El estado es error interno");
            }
                
            #endregion
        }
    }
}
