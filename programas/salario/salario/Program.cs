using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            int extras;
            int total;
      
           

            Console.Write("ingrese horas de trabajo: ");
            horas = Convert.ToInt32(Console.ReadLine());

            if (horas< 39 )
            {
                Console.WriteLine(horas * 16);
            }
            else if (horas >40)
            {
             
               Console.WriteLine( horas * 16);


                Console.Write("ingrese horas extras: ");
                extras = Convert.ToInt32(Console.ReadLine());

                total = extras * 20;

                Console.WriteLine(horas + total);



            }

        }
    }
}
