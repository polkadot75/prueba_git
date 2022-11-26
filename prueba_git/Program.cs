using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Hello World!");
            Console.WriteLine("HAW AR YU?");
            Console.WriteLine("¿Cual es tu edad?");

            int edad = int.Parse(Console.ReadLine());


            if (edad>18)
            {
                Console.WriteLine("! Eres mayor de edad !");
            }
            else
            {
                Console.WriteLine("! No eres mayor de eddad !");
            }


        }
    }
}
