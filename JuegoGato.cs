using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Gatito
{
    internal class JuegoGato
    {
        public int[,] Tablero = new int[3,3];
        public string Jugador, JugadorG;
        public int Disponible;

        public void Volado()
        {
            Random rnd = new Random();
            var resultado = rnd.Next(1, 3);
            Jugador = (resultado == 1) ? "X" : "O";
            Disponible = 9;
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

            if(Disponible == 0)
            {
                Console.WriteLine("Ya no hay movimientos");
                return false;
            }

            do
            {
                Console.WriteLine("Escribe la coord X: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe la coord Y: ");
                y = Convert.ToInt32(Console.ReadLine());
            } while (!(x >= 0 && x <= 2) || !(y >= 0 && y <= 2) 
                    || Tablero[x,y] != 0);

            if(Jugador == "X")
            {
                Tablero[x, y] = 1;
                Jugador = "O";
            }
            else
            {
                Tablero[x, y] = 2;
                Jugador = "X";
            }
            Disponible--;
            return true;
        }

        public bool Ganador()
        {
            if (Jugador == "X")
            {
                JugadorG = "O";
            }
            if (Jugador == "O") {
                JugadorG = "X";
             }

            Console.WriteLine("El ganador es: " + JugadorG);
            return true;    
        }

        public bool ValidarGanador()
        {
            if (Tablero[0, 0] == Tablero[0, 1] && Tablero[0, 1] == Tablero[0, 2])
            {
                
                return true;

            }
            return false;
            if (Tablero[1, 0] == Tablero[1, 1] && Tablero[1, 1] == Tablero[1, 2])
            {
                return true;
            }
            return false;
            if (Tablero[2, 0] == Tablero[2, 1] && Tablero[2, 1] == Tablero[2, 2])
            {
                return true;
            }
            return false;

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
