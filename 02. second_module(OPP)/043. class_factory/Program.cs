using System;

namespace _044._class_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // ahora solo accedemos a la clase estatica, y enviamos el cmd que queremos instanciar
            var inst = ClassFactory.ClassFactoryCreate("enviar_mensaje");
            var enviador = new EnviadorMensaje(inst);
            enviador.EnviarMensaje("Un mensaje enviado con el enviar mensaje");

            Console.ReadKey();

            // ahora lo intentaos con correo
            var instCorreo = ClassFactory.ClassFactoryCreate("enviar_correo");
            // como enviado ya esta creado solo hacemos el llamado con el mismo pero con el instCorreo
            enviador = new EnviadorMensaje(instCorreo);
            enviador.EnviarMensaje("Un mensaje enviado con el correo");

            Console.ReadKey();
        }
    }

    public static class ClassFactory
    {
        // creamos el metodo el cual retornara un tipo de Interface
        public static IEnviadorMensaje ClassFactoryCreate(string cmd)
        {
            if(cmd.Equals("enviar_mensaje"))// si el cmd es sms
            {
                return new EnviarMiniMensaje();// retorno enviar mini mensaje
            }
            if(cmd.Equals("enviar_correo"))// si es enviar_correo
            {
                return new EnviarCorreo();// retorno enviar correo
            }

            // ya que los dos retornos estan dentro de if, tengo que o elejir un retorno por defecto
            // o devolver una excepcion
            throw new ApplicationException();
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
