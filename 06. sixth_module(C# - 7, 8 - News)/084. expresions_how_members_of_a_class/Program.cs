using System;

namespace _084._expresions_how_members_of_a_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Rectangulo(25);
        }
    }

    class Rectangulo
    {
        // propiedades normales
        public int Altura { get; set; }
        public int Anchura { get; set; }

        // propiedades con expresiones

        public int UnaPropiedadCualquiera 
        { 
            get => UnaFuncion(); 
            set => AsignarAlturaYAnchura(value);
        }

        public int Area => Anchura * Altura;
        
        public int Respuesta => UnaFuncion();

        public int UnaFuncion()
        {
            return 42;
        }

        // constructor por defecto
        public Rectangulo()
        {   
        }

        // constructor con parametros
        public Rectangulo(int dimension) 
            => AsignarAlturaYAnchura(dimension);

        // metodo privado que e inoca en la expresion del constructor con parametros
        private void AsignarAlturaYAnchura(int altura)
        {
            Anchura = altura;
            Altura = altura;
        }

        // hasta en el destructor
        ~Rectangulo() => Destruir();

        private void Destruir()
        {
            // en si el destructor se encarga de borrar todo el registo de la instancia
            // pongo este codigo aqui debajo para que no quede asi tan vacio
            Altura = 0;
            Anchura = 0;
        }
    }
}
