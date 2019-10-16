using System;

namespace _050._sealed_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nac = new Nacionalidad();
            var color = new Color();// que este sellada no signica que no se pueda instanciar
        }
    }

    // defino una clase padre
    abstract class Persona
    {

    }

    // heredo al primer hijo
    class Nacionalidad : Persona
    {

    }

    // heredo a un nieto (por asi decirlo), pero en este caso lo defino como sealed
    // para que ya no pueda haber mas herencias en base a este
    sealed class Color : Nacionalidad
    {

    }
}
