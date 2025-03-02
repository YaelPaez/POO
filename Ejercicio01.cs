using Microsoft.VisualBasic;
using System.Transactions;

namespace Tee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("¿Que dia es hoy?");
            Console.WriteLine("ingresa un numero del i al 7");
            dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Hoy es Domingo");
                    break;
                case 2:
                    Console.WriteLine("Hoy es Lunes");
                    break;
                case 3:
                    Console.WriteLine("Hoy es Martes");
                    break;
                case 4:
                    Console.WriteLine("Hoy es Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Hoy es Jueves");
                    break;
                case 6:
                    Console.WriteLine("Hoy es Viernes");
                    break;
                case 7:
                    Console.WriteLine("Hoy es Sabado");
                    break;
                default:
                    Console.WriteLine("La opcion no es valida");
                    break;
            }
            Console.ReadKey();
        }
    }
}