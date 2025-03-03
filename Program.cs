using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool acierto = false;

            Console.WriteLine("Adivina el numero del 1 al 3");

            bool bandera = true;
            do
            {
                var aleatorio = new Random();
                var num = aleatorio.Next(0, 3);

                Console.WriteLine("Dime el numero:");
               
                int opc = int.Parse(Console.ReadLine());

                if (num == opc)
                    {
                    acierto = true;
                   
                    } else { Console.WriteLine("Intenta de nuevo!"); }

                } while (acierto==false);
            Console.WriteLine("Has acertado");
            Console.ReadKey();

            /*----------------------------------------------------------------------*/

            /*bool bandera = true;
            while (bandera)
            {
                Console.WriteLine("deseas continuar");
                Console.WriteLine("S/N:");
                string opc = Console.ReadLine().ToUpper().Trim().Substring(0, 1);

                if (opc == "N") bandera = false;
            }*/
        }
    }
}
