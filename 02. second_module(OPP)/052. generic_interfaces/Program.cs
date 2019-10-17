using System;
using System.Collections.Generic;

namespace _051._generic_interfaces
{
    class Program
    {
        enum SelecctionFactory
        {
            Collection = 1,
            Diccionary = 2
        };

        static void Main(string[] args)
        {
            var inst = FacotoryColeccion<string, int>(SelecctionFactory.Collection);
            inst.Agregar("Nombre", 86);
        }

        // class factory, usamos enum para hacerlo mas mantenuble
        static IMiDobleColeccion<T, M> FacotoryColeccion<T, M>(SelecctionFactory seleccionador)
        {
            if(seleccionador == SelecctionFactory.Collection)
            {
                return new MiDobleColeccion<T, M>();
            }
            if(seleccionador == SelecctionFactory.Diccionary)
            {
                return new MiDobleColeccionDiccionario<T, M>();
            }

            throw new ApplicationException();
        }
        
    }

    interface IMiDobleColeccion<T, M> 
    {
        void Agregar(T valorT, M valorM);   
    }

    class MiDobleColeccion<T, M> : IMiDobleColeccion<T, M> 
    {
        public List<T> MiListT { get; set; }
        public List<M> MiListM { get; set; }

        public MiDobleColeccion()
        {
            MiListT = new List<T>();
            MiListM = new List<M>();
        }

        public void Agregar(T valorT, M valorM)
        {
            MiListT.Add(valorT);
            MiListM.Add(valorM);
        }
    }

    class MiDobleColeccionDiccionario<T, M> : IMiDobleColeccion<T, M> 
    {
        public Dictionary<T, M> Diccionario { get; set; }
        
        public void Agregar(T valorT, M valorM)
        {
            Console.WriteLine("Diccionarioooo!!!");
        }
    }

}
