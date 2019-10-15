using System;
using System.Collections.Generic;

namespace _041._object_and_is_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // object en si es el tipo universal
            Object o = "cadena";
            o = true;
            o = 90.45;
            o = new List<string>(){"Nombre", "Nombre", "Nombre"};
            // como ves puedes asignarle lo que quieras, pero con una condicion
            // no puedes acceder a sus atributo, por ejemplo:
            // el atributo lenght de una cadena
            Object cadena = "Esta es una cadena media larga";
            // cadena.Lenght; // da error
            // lo que puedes hacer es, parcear object, ya esto lo hemos visto, seria asi:
            string cadenaParcer = (string)cadena;//parseamos
            int longitudCadena = cadenaParcer.Length; // ahora si tenemos acceso a los atributos dignos de una string
            
            //pero hay un problema, y es que para parcear debemos saber el tipo, de manera que nos vemos obligados a usar el operador "is"
            // ya lo hemos visto en el curso, pero ahora lo trataremos mas practico
            void ParcearTipo(Object obj)
            {
                if(obj is string)// si es string pues lo parceamos a string
                {
                    obj = (string)obj;
                }
                if(o is double)// si es double, pues a double, y asi sucesivamente, obvio que no repetiremos tantos string, para eso se usa el switch pero lo veremos mas adelante
                {
                    obj = (double)obj;
                }
            }
            Object doubletipe = 89;
            ParcearTipo(doubletipe);



            // lo mismo ocurre con los metodos
            void RecibirLoQueSea(Object obj)
            {
                if(obj is List<double>)// si lo recibido es double
                {
                    var listParcer = (List<double>)obj;//lo parseamos
                    foreach (var list in listParcer)
                    {
                        Console.WriteLine(list);   
                    }
                }
                else{
                    Console.WriteLine(obj);
                }
            }

            // puedes pasarle lo que desees, obvio, al igual que pasa cuando lo usas oara varibles, no tienes acceso a las propiedades de cada tipo, pues no esta especificado
            RecibirLoQueSea("cadena de texto");
            RecibirLoQueSea(90.45577567);
            RecibirLoQueSea(new List<double>(){56.3652, 45.2356, 89.3574});
            // asi que ten cuidado al usar object
        }
    }
}
