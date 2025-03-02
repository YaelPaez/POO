using Microsoft.VisualBasic;
using System.Transactions;

namespace Tarea1
{
    internal class Ejercicio02
    {
        static void Main(string[] args)
        {
            // declrarmos variable edad como tipo int

            int edad;

            // Le indicamod que hace la app y le pedimos el dato al usuario

            Console.WriteLine("Te diré que eres segun tu edad");
            Console.WriteLine("Ingresa tu edad:");

            // Leemos la linea de consola y convertimos el dato a tipo int
            // con int.Parse() y lo guardamos en la var edad

            edad = int.Parse(Console.ReadLine());

            // con el switch vamos a pedir evaluar un caso por rango,
            // es decir, si el caso (el cual sera la edad) es mayor o
            // igual a 110,es decir, si la edad esta en el rango de 110 o mas
            // retornara el mensaje correspondiente, y despues si case es mayor
            // o igual a 65, como la condicion anterior no se cumplio, si se
            // cumple esta, madendara el mensaje, y asi sucesivamente hasta
            // el ultimo caso

            switch (edad)
            {
                case >= 110:
                    Console.WriteLine("Un humano no puede vivir tanto");
                    break;
                case >= 65:
                    Console.WriteLine("Eres un Adulto Mayor");
                    break;
                case >= 18:
                    Console.WriteLine("Eres un Adulto");
                    break;
                case >= 13:
                    Console.WriteLine("Eres un Adolescente");
                    break;
                case >= 0:
                    Console.WriteLine("Eres un Niño");
                    break;
                default:
                    Console.WriteLine("Edad invalida!");
                    break;
            }
            // se oprime calquier tecla para finalizar lla app
            Console.ReadKey();
        }
    }
}