using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace _047._generic_methods
{

    /*
    NOTA: SI CORRES ESTE PROGRAMA SOBRE NET CORE, PROBABLEMENTE TE DE ERROR DE SERIALIZACION, YA QUE LA SERIALIZACION ESA EN BASE A NET FRAMEWORK, POR TANTO
    ES POSIBLE QUE CRASHEE
    */

    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona(){ Nombre = "Fulano"};
            var xml_persona = Serializar<Persona>(persona);

            var empresa = new Empresa(){Nombre = "Barcelo Dominicana"};
            var xml_empresa = Serializar<Empresa>(empresa);
        }

        private  static string Serializar<T>(T valor)
        {
            var serializador = new XmlSerializer(typeof(T));

            using(var escritorString = new StringWriter())
            {
                serializador.Serialize(escritorString, valor);
                return escritorString.ToString();
            }
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
    }

    class Empresa
    {
        public string Nombre { get; set; }
    }
}
