using System;

namespace _010._work_with_dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2019, 12, 30);
            DateTime fechaConHora = new DateTime(2007, 9, 20, 10, 45, 56);

            // se usa el toString para mostrar en consola, si no se especifica la hora tomara una por defecto
            Console.WriteLine(fecha.ToString()); 
            Console.WriteLine(fechaConHora.ToString());

            // se puede dar formato a la salida, por ejemplo
            Console.WriteLine(fechaConHora.ToString("MM/dd/yyyy"));// mes / dia / ano
            Console.WriteLine(fechaConHora.ToString("dd-MM-yyyy hh:mm:ss"));// dia / mes / ano solo los dos ultimos digitos
            // NOTA: se pueden usar los caracteres que se quira: / - : * + = @ los que quieras
            Console.WriteLine(fechaConHora.ToString("MM@dd@yyyy"));// obviamente si pones el @ no sera muy legible

            // tambien puedes agregar dias, meses, horas, minutos, etc...
            Console.WriteLine(fecha.AddDays(12).ToString()); // 30 de diciembre del 2019 mas 12 dias, seria 11 de enero del 2020
            Console.WriteLine(fecha.AddMonths(1).ToString()); // 30 de diciembre del 2019 mas 1 mes, seria 30 de enero del 2020
            Console.WriteLine(fecha.AddYears(1).ToString()); // 30 de diciembre del 2019 mas 1 ano, seria 30 de diciembre del 2020
            
            // otra utlidad que tenemos es saber que dia de la semana era la fecha indicada, ejemplo:
            Console.WriteLine(fecha.DayOfWeek);// mostrara si ese dia era lunes, miercoles, sabado...

            // si solo quieres saber la fecha de un datetime pues solo
            Console.WriteLine(fechaConHora.Date);// mostrara la fecha solamente
            Console.WriteLine(fechaConHora.Day);// el dia de la fecha en base a los dias del mes
            Console.WriteLine(fechaConHora.DayOfYear);// dia del ano, oseas en base a 365 dias
            
            // quires saber cuantos dias, meses, horas, minutos etc hay entre una fecha u otra, pues simple
            Console.WriteLine(fecha.Subtract(fechaConHora).Days);// me mostrara el total de dias entre una fecha y otra
            Console.WriteLine(fecha.Subtract(fechaConHora).TotalHours);// me mostrara el total de horas entre una fecha y otra
            
            Console.ReadKey();
        }
    }
}
