using System;

namespace _009._logic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
           var a = true;
           var b = false;
           var c = true;
           var d = true;

           Console.WriteLine(!a); // negacion de a, si esta true pasa a false y viceversa

           // conjucion (solo sera true si ambos son true)
           Console.WriteLine(a & d);// resultado sera true porque ambas son verdades
           Console.WriteLine(a & b);// resultado sera false porque una de ambos es falsa
           // usando un & se toma en cuanta el hecho de que si el primero es faslo no analice el segundo
           // si deseas que se analicen todos, pues, usa dos &&, asi:
           Console.WriteLine(a && b);


           // disyuncion exclusiva (dara false simepre y cuando sean ambos del mismo valor - true y true - false y false)
           Console.WriteLine(a ^ c);// ambos son iguales asi que dara false
           Console.WriteLine(a ^ b);// son diferentes asi que dara true

           // disyuncion inclusiva (dara true siempre y cuando una sea true)
           Console.WriteLine(a | b);// sera true si una de las dos es verdadera
           Console.WriteLine(b | b);// como ambas son falsas dara false
           
           // cuando se usa un solo | se toma en cuenta el hecho de que si el primero es true ya es true en total
           // y solo se analizara el segundo si el primero es false, pero si quieres confirmar ambos usa doble ||
           Console.WriteLine(a || b);
           
           
        }
    }
}
