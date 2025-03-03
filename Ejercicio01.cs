using Microsoft.VisualBasic;
using System.Transactions;

namespace Tee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declara variable dia como tipo Int
            
            int dia;

            // se muestra en pantalla de que se trata la app
            // y pedimos el dato
            
            Console.WriteLine("¿Que dia es hoy?");
            Console.WriteLine("ingresa un numero del i al 7");
            
            // Leemos la consola Y convertimos el dato a tipo int
            // para guardarlo en la var dia
            
            dia = int.Parse(Console.ReadLine());

            // Con el Switch en caso de que el numero ingresadp sea
            // 1 se mostrara Domigo o en caso de 7 sea Sabado
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
                // en caso que sea otro valor diferente
                default:
                    Console.WriteLine("La opcion no es valida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
