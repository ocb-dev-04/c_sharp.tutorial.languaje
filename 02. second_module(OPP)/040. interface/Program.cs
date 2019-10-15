using System;

namespace _040._interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciamos la clase
            var miniMensaje = new EnviarMiniMensaje();

            //podemos enviarle un tipo EnviarMiniMensaje como parte de la interface ya que hereda la interface y la implementa por obligacion de contrato
            Enviar(miniMensaje, "Hola hola");
            // a esto llamamos herencia de interface ya que al estar obligados a implementar
            // todos los metodos de la interface C# estara seguro que tiene cualquier metodo que llame de ella 
        }

        public static void Enviar(IEnviarMensaje mensajero, string msj)
        {
            mensajero.EnviarMensaje(msj);
        }
    }

    interface IEnviarMensaje
    {
        void EnviarMensaje(string msj);
    }

    // heredamos la interface en una clase
    class EnviarMiniMensaje : IEnviarMensaje
    {
        // al heredar la interface nos obliga a implementar dicho metodo
        public void EnviarMensaje(string msj)
        {
            Console.WriteLine(msj);
        }

        // pero tambien  podemos definir mas metodos que no necesariamente esten en la interfaz
        public void OtroMetodo()
        {
            Console.WriteLine("Este es otro metodo ajeno a la interface");
        }
    }

}
