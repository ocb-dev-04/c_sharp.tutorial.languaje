using System;
using System.Collections.Generic;

namespace _036._encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancio mi clase
            var il = new IteradorLista();
            // le asigno una lista a mi propiedad Lista, fijate que es a la propiedad no al campo _lista
            il.Lista = new List<int>(){85, 96, 78, 25, 63};
            il.ShowList();// llamo el metodo showlist sin pasar parametros ya que al usar la instancia a la cual le asigne la lista anteriormente, esa informacion la contiene la clase

            Console.ReadKey();
        }
    }

    class IteradorLista 
    {
        #region Fields

        private List<int> _lista;
            
        #endregion

        #region Properties

        public List<int> Lista 
        { 
            // en caso de que desees solo asignarle valor a la lista y no leerlo desde fuera, puedes declarar tanto el 
            // get como set con el modificador de acceso private
            get{
                return _lista;
            }
            set{
                if(value != null)// examino si la lista no es null
                    _lista = value;
                else
                    Lista = new List<int>();// en caso que lo sea le asigno una lista vacia
            }
        }

        #endregion
        
        #region Construct

        public IteradorLista()
        {
            _lista = new List<int>();// le asigno una lista vacia por si acaso invocan el metodo sin antes haber enviado info a la propiedad para el campo lista
        }

        #endregion
    
        #region Methods

        public void ShowList()// no necesito argumentos ya que por meio de la propiedad le asigne valor a la lista
        {
            foreach (var elementoList in _lista)// ya que con la instancia le asigne valor al campo _lista por medio de la propiedad Lista, solo debo usarla como coleccion para leerla
            {
                Console.WriteLine(elementoList);
            }
        }

        #endregion
    }
}
