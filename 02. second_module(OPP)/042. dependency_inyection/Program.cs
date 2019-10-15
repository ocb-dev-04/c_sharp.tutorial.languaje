using System;

namespace _043._dependency_inyection
{
    class Program
    {
        static void Main(string[] args)
        {
            // luego instancia la clase de envio que es la que tiene la inyeccion de dependencia en el constructor
            // en este caso al seleccionar el constructor por defecto se usara la dependencia de enviarmi nimensaje
            var enviadorMensaje = new EnviadorMensaje();
            // luego uso el metodo que tiene la interface, y que por el contrato, lo tienen que tener tambien las clases hijas
            enviadorMensaje.EnviarMensaje("hola, este es el mensaje que enviare!!!");
            
            // y ahora al enviar la de correo se ejecutara la de correo obviamente
            var enviarCorreo = new EnviarCorreo();
            enviadorMensaje = new EnviadorMensaje(enviarCorreo);
            enviadorMensaje.EnviarMensaje("Hola este es el correo");
            Console.ReadKey();
        }
    }

    public interface IEnviadorMensaje
    {
        void EnviarMensaje(string mensaje);
    }

    // clase que invoco y que aplica la inyeccion de dependencia
    public class EnviadorMensaje
    {

        private IEnviadorMensaje _enviadorMensaje;

        // puedes optar por usar un constructor por defecto, que lo que hara es inicializar una dependencia por defecto
        public EnviadorMensaje()
        {
            // en este caso la inyeccion por defecto seria la de enviarminimensaje
            _enviadorMensaje = new EnviarMiniMensaje();
        }

        // si notas, paso la interface como parametro en el contructor, y se la asigno a un campo de la misma clase
        public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }

        public void EnviarMensaje(string mensaje)
        {
            _enviadorMensaje.EnviarMensaje(mensaje);
        }
    }

    public class EnviarMiniMensaje : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

    public class EnviarCorreo : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
