using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gatito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var juego = new JuegoGato();
            juego.Volado();
            do
            {
                juego.Dibujar();
                juego.Movimiento();
            } while (true);
            Console.ReadKey();
        }
    }
}
