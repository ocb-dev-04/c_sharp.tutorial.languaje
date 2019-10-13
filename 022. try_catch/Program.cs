using System;

namespace _022._try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = 0;

            try
            {
                // como la division entre 0 da error la ponemos dentro del try
                c = a / b;
            }
            catch(DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("A ocurrido un error al dividir entre 0: {0}", divideByZeroException.Message);// la propiedad Message de la excepcion muestra el nombre en si de la excepcion
            }
            // obviamente en este caso se ponen distintos tipos de excepciones pero, en el caso de un programa en especifico pues pones la excepcion que puede
            // suceder y le ponemos otra que es la de por defecto
            catch(IndexOutOfRangeException indexOutOfRangeException)
            {
                Console.WriteLine("A ocurrido un error fuera de rango: {0}", indexOutOfRangeException.Message);// la propiedad Message de la excepcion muestra el nombre en si de la excepcion
            }
            // el catch por defecto se coloca de ultimo, de esta manera si el error no esta previamente visto, pues se ejecuta este y ya
            catch (Exception ex)
            {
                Console.WriteLine("A ocurrido un error: {0}", ex.Message);// la propiedad Message de la excepcion muestra el nombre en si de la excepcion 
            }
            finally
            {
                Console.WriteLine("Esto se muestra obligatoriamente");
            }
        }
    }
}
