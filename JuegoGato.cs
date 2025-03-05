using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gatito
{
    internal class JuegoGato
    {
        public int[,] Tablero = new int[3,3];
        public string Jugador;

        public void Volado()
        {
            Random rnd = new Random();
            var resultado = rnd.Next(1, 3);
            Jugador = (resultado == 1) ? "X" : "0";
        }

        public void Dibujar()
        {
            Console.WriteLine(" -----------");
            Console.WriteLine("| " + Imagen(0, 0) + " | " + Imagen(0, 1) + " | " + Imagen(0, 2) + " |");
            Console.WriteLine(string.Format("| {0} | {1} | {2} |", Imagen(1, 0), Imagen(1, 1), Imagen(1, 2)));
            Console.WriteLine($"| {Imagen(2, 0)} | {Imagen(2, 1)} | {Imagen(2, 2)} |");
            Console.WriteLine(" -----------");
            Console.WriteLine($"Juagador actual: {Jugador}");
        }

        public bool Movimiento()
        {
            int x, y;
            do
            {

                Console.WriteLine("Escrib3 coordenada X:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escrib3 coordenada Y:");
                y = Convert.ToInt32(Console.ReadLine());
            } while (!(x >= 0 && x <= 2) || !(x >= 0 && x <= 2));

            if (Jugador == "X")
            {
                Tablero[x, y] = 1;
                Jugador = "O";
            }
            else
            {
                Tablero[x, y] = 2;
                Jugador = "X";
            }

            return true;
        }

        public string Imagen(int x, int y)
        {
            var valor = Tablero[x,y];
            switch (valor)
            {
                case 0:
                    return " ";
                case 1:
                    return "X";
                case 2:
                    return "O";
                default:
                    return " ";
            }
        }

    }
}
