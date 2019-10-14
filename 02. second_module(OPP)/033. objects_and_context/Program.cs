using System;

namespace _033._objects_and_context
{
    class Program
    {
        static void Main(string[] args)
        {
            // la informacion de la instancia e1 es diferente a las i2
            var e1 = new  Empresa();
            e1._NombreLegal = "Fulano";
            e1._Direccion = "Que se yo";

            // 
            var e2 = new  Empresa();
            e2._NombreLegal = "Fulano Dos";
            e2._Direccion = "Que se yo Dos";
        }
    }

    class Empresa
    {
        public string _NombreLegal;
        public string _Direccion;

        public void MethodName(Empresa emp)
        {
            this._nombreLegal = this._NombreLegal;
            this._direccion = this._Direccion;
            var miDireccion = _Direccion;
            var miNombreLegal = _NombreLegal;
            var _nombreLegal = emp._NombreLegal;
            var _direccion = emp._Direccion;
        }
    }
}
