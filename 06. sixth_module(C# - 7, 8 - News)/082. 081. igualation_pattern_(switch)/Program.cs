using System;

namespace _082._081._igualation_pattern__switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangulo = new Triangulo(){ Anchura = 50, Altura = 30, Base = 25 };// obviamente solo el triangulo tiene base, ya que en el caso de los rectanguloso la anchura tomara el lugar de base
            var cuadrado = new Rectangulo(){ Anchura = 40, Altura = 40 };
            var rectangulo = new Rectangulo(){ Anchura = 60, Altura = 80 };

            PatronDeIgualacion(triangulo);
            PatronDeIgualacion(cuadrado);
            PatronDeIgualacion(rectangulo);



            Console.ReadKey();
        }

        static void PatronDeIgualacion(Figura figura)
        {
            // el roden imorta, asi que si tienes una figura que puede tener variaciones, 
            // primero pon las variaciones nates que la opcion por defecto

            switch(figura)
            {
                case Triangulo t:
                    Console.WriteLine($"Triangulo {t.Anchura} {t.Altura} {t.Base}");
                    break;
                // primero ponemos el rectangulo que pueded variar en caso de que los lados sean iguales sera un cuadrado
                case Rectangulo sq when sq.Altura == sq.Anchura:
                    Console.WriteLine($"Cuadrado {sq.Anchura} {sq.Altura}");
                    break;
                // y entonces al final ponemos la opcion del reactangulo la cual seria como por defecto
                // pasa igual que con el try catch() que pones la exception por defecto al final
                case Rectangulo r:
                    Console.WriteLine($"Rectangulo {r.Anchura} {r.Altura}");
                    break;
                default:
                    Console.WriteLine("Otro");
                    break;
            }
        } 
    }

    class Figura
    {
        public int Anchura { get; set; }
        public int Altura { get; set; }
    }

    class Triangulo : Figura
    {  
        public int Base { get; set; }
    }

    class Rectangulo : Figura
    {

    }
}
