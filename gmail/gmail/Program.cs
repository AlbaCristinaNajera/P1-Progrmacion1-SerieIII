using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa");

            Console.WriteLine("Por favor ingrese su nombre");
            string nombre= Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido");
            string apellido = Console.ReadLine();
            
            string correo = generarCorreo(nombre,apellido);

            Console.WriteLine("Tu cuenta de correo electronico es: " + correo);
            Console.ReadLine();
        }
        static string generarCorreo(string nombre, string apellido)
        {
            string nombreCorto = nombre.Substring(0, Math.min(nombre.Length, 3);
            string apellidoCorto = nombre.Substring(0, Math.min(apellido.Length, 3);
        }
    }
}
