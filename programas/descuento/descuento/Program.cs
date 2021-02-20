using System;

namespace descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int descuento = 20;


            Console.Write("ingrese una cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            if (cantidad >= 300)
            {
                Console.WriteLine(cantidad - descuento);
            }
            else if (cantidad < 300)
            {
                Console.WriteLine("no hay descuento");
            }


        }
    }
} 
