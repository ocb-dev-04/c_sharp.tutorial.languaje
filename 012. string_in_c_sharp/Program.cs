using System;

namespace _012._string_in_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Michael", 
                    phrase = "This is a long phrases",
                    emailValid = "fulano@gmail.com",
                    emailInvalid = "fulano@gamil.com";

            #region length

            Console.WriteLine("Ejemplos de length");
            Console.WriteLine(name.Length);
            Console.WriteLine(phrase.Length);
                
            #endregion
            
            #region substring

            Console.WriteLine("Ejemplos de substring");
            Console.WriteLine(name.Substring(2));
            // tambien puedes decirle donde empezar y cuantos caracteres tomar, por ejemplo:
            // empezara en el caracter numero 5 y a partir de este tomara 8 caracteres
            Console.WriteLine(phrase.Substring(5, 8));
                
            #endregion
    
            #region startswith

            Console.WriteLine("Ejemplos de startswith");
            Console.WriteLine(name.StartsWith("Mi"));// retornara true
            Console.WriteLine(name.StartsWith("Mica"));// retornara false, ya que inicia con micha no con mica
            Console.WriteLine(phrase.StartsWith("this")); // retornara false porque empieza con this pero la "t" va mayuscula
            Console.WriteLine(phrase.StartsWith("This")); // retornara true porque empieza con this y la "t" esta mayuscula
                
            #endregion

            #region endswith
            
            Console.WriteLine("Ejemplos de endswith");
            Console.WriteLine(name.EndsWith("chael"));// retornara true
            string validGmail = "@gmail.com";// la subcadena a buscar puede estar definida en una variable o traerla de base de datos, JSON, de donde sea
            Console.WriteLine(emailValid.EndsWith(validGmail));// retornara true
            Console.WriteLine(emailInvalid.EndsWith(validGmail));// retornara false
                
            #endregion
            
            #region contains
            
            Console.WriteLine("Ejemplos de constains");
            Console.WriteLine(name.Contains("icha"));// retorna true
            Console.WriteLine(phrase.Contains("is a"));// retorna true
            Console.WriteLine(phrase.Contains("is a Long"));// retorna false, porque es sencible a mayusculas y minusculas
            Console.WriteLine(phrase.Contains("is a long"));// retorna true, porque es sencible a mayusculas y minusculas
                
            #endregion
            
            #region indexof
            
            Console.WriteLine("Ejemplos de indexof");
            Console.WriteLine(phrase.IndexOf("is"));// nos mostrara 2 que es donde empiezaz el is, ojo, tomara el is de la palabra Th.is. osea que retornara la primera coincidencia
            Console.WriteLine(phrase.IndexOf("long"));// nos mostrara  que es es donde empieza
                
            #endregion
            
            #region operador (+)
        
            Console.WriteLine("Ejemplos de concatenacion");
            Console.WriteLine(name + " " + phrase);// retorna "Michael This is a long phrases"
            Console.WriteLine(name + validGmail);// retorna Michael@gmail.com

            #endregion
            
            #region tolower
            
            Console.WriteLine("Ejemplo de tolower");
            Console.WriteLine(name.ToLower());// retorna "michael" la M la pone minuscula
            Console.WriteLine(phrase.ToLower());// retorna "this is a long phrases" la T la pone minuscula
                
            #endregion
            
            #region toupper
            
            Console.WriteLine("Ejemplo de toupper");
            Console.WriteLine(name.ToUpper()); // retorna "MICHAEL" todo en mayusculas
            Console.WriteLine(phrase.ToUpper());// retorna "THIS IS A LONG PHRASES" todo en mayusculas
                
            #endregion
            
            #region trim
            
            Console.WriteLine("Ejemplos de trim");
            string exampleTrim = " Fulano ";
            Console.WriteLine(exampleTrim);// muestra laa cadena con todo y los espacio " Fulano "
            Console.WriteLine(exampleTrim.Trim());// muestra la cadena sin espacios
                
            #endregion
            
            #region format
            
            Console.WriteLine("Ejemplo de format");
            string ejemploFormat = "Tu nombre es: {0} y tu apellido es: {1}!!";
            string nameFormat = "Jose", lastNameFormat = "Baez";
            // primero se pasa la varible a formatear, y luego las variables a mostrar en el orden debido
            Console.WriteLine(string.Format(ejemploFormat, nameFormat, lastNameFormat)); // el lugar de la variable va a ser mostrado donde sea que este su lugar en el template
            // si repetimos el indice en la string formateada se mostrar la variable la cual le toca ese indice
            Console.WriteLine(string.Format("{0} , {1}, {0}, {0}", nameFormat, lastNameFormat));// mostrara nombre, apellido, nombre, nombre

            #endregion
            
            #region replace
            
            Console.WriteLine("Ejemplo de replace");
            string templateToReplace = "Hola @nombre tu apellido es @apellido";
            string templateReplace = templateToReplace.Replace("@nombre", "Juan");// reemplazamos el @nombre por carlos
            templateReplace = templateToReplace.Replace("@apellido", "Matos");// aqui reemplazamos el @apellido por el apellido
            Console.WriteLine(templateReplace);
            // al igual que con el format, si repites en el template el @nombre, o el @apellido, se mostrara las veces que se repita
            templateToReplace = "@nombre, @nombre, @nombre";
            Console.WriteLine(templateToReplace.Replace("@nombre", "Juan"));

            // tambien puedes usarlo para reemplazar un caracter en si, por ejemplo
            string replaceChar = "Este es el titulo de un articulo";// imaginemos que este es el titulo de un articulo we
            string validWebTitle = replaceChar.Replace(" ", "_");// reemplazamos todos los espacios en blanco por un "_"
            Console.WriteLine(validWebTitle);

            #endregion
            
            #region equals
            
            Console.WriteLine("Ejemplos de equals");
            Console.WriteLine(name.Equals(name));// retornara true, ya que name es igual a name
            Console.WriteLine(name.Equals("Esteban"));

            #endregion
            
            #region split
            
            Console.WriteLine("Ejemplo de split");
            string [] phrasesSplitBySpace = phrase.Split(" ");// dividira el string por cada " " (espacio) que encuentra
            for(int i = 0; i <= phrasesSplitBySpace.Length - 1; i++)
            {
                Console.WriteLine(phrasesSplitBySpace[i]);
                /*
                esto mostrara algo asi:

                This
                is
                a
                long
                phrases
                 */
            }

            #endregion
        
            #region is null or white space

            string stringEnBlanco = "   ";
            string stringNula = null;
            Console.WriteLine("Ejemplos con IsNullOrWhiteSpace");
            Console.WriteLine(string.IsNullOrWhiteSpace(stringEnBlanco));// retornara true porque solo esta en blanco
            Console.WriteLine(string.IsNullOrWhiteSpace(stringNula));// retornara true porque es nula
            Console.WriteLine(string.IsNullOrWhiteSpace(name));// retornara false porque tiene contenido
                
            #endregion

            #region is null or empty

            Console.WriteLine("Ejemplos con IsNullOrEmpty");
            Console.WriteLine(string.IsNullOrEmpty(stringEnBlanco));// retornara false porque no es nula aunque no esta vacia ya que tiene espacio los cuales visualmente no son nada pero los detecta como contenido
            Console.WriteLine(string.IsNullOrEmpty(stringNula));// retornara true porque es nula
            Console.WriteLine(string.IsNullOrEmpty(name));// retornara false porque tiene contenido
                
            #endregion
        }
    }
}
