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
                if(juego.Movimiento() == false)
                {
                    break;
                }
                if (juego.ValidarGanador() == true)
                {
                    juego.Ganador();
                    break;
                }
            } while (true);
            Console.ReadKey();

            /*juego.Volado();
            juego.Dibujar();
            juego.Movimiento();
            juego.Dibujar();
            Console.ReadKey();*/
        }
    }
}
