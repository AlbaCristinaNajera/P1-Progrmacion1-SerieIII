using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora de precios");

            Console.WriteLine("Ingrese el precio del primer producto");
            int precio1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del segundo producto");
            int precio2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del tercer producto");
            int precio3 = Convert.ToInt32(Console.ReadLine());

            int total = precio1 + precio2 + precio3;

            if (total > 500) 
            {
                total = total - (total * 10 / 100);
            }
            Console.WriteLine("El total de los productos es: " + total + " centimos");
            Console.WriteLine("Gracias por usar el programa");

            Console.ReadLine();
        }
    }
}
