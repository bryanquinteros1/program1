using System;

namespace dia_laboral
{
    class Program
    {
        static void Main(string[] args)
        {

            string dia;

            Console.WriteLine("Introduce dia:");
            dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("dia laboral.");
                    break;
                case "martes":
                    Console.WriteLine("no es dia laboral.");
                    break;
                case "miercoles":
                    Console.WriteLine("dia laboral.");
                    break;
                case "jueves":
                    Console.WriteLine("no es dia laboral.");
                    break;
                case "viernes":
                    Console.WriteLine("dia laboral.");
                    break;
                case "sabado":
                    Console.WriteLine("no es dia laboral.");
                    break;
                case "domingo":
                    Console.WriteLine("no es dia laboral.");
                    break;

                default:
                    Console.WriteLine("introduzca un dia de la semana porfavor :).");
                    break;



            }

        }
    }
}