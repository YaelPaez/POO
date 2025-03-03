using System;
namespace Tarea1
{
	public class Ejercicio05
	{
		static void Main()
		{
			// Se iNicializan variables

			int numeroVentas;
			double ventas=0, comision=0;
			string nombre, msg="";

			// se muestra en pantalla de que se trata la app
			// y pedimos los datos de nombre y canridad de ventas
			// realizadas

			Console.WriteLine("Cacula tu comision de ventas");
			Console.WriteLine("Ingresa tu nombre");

			// leemos consola para el nombre y guardamos en la variable

			nombre = Console.ReadLine();

			Console.WriteLine("Ingresa la cantidad de ventas que realizastte:");

			// Leemos la consola y convertimos el dato a tipo int

			numeroVentas = int.Parse(Console.ReadLine());

			// Con un bucle for, pedimos las contidades del numero de ventas

			for (int i = 1; i <= numeroVentas; i++)
			{
				Console.WriteLine("Ingresa el monto de la venta " + i + ":");
				double venta = double.Parse(Console.ReadLine());
				ventas = ventas + venta;
			}

			// con el switch depende del rango de la cantidad de ventas, se
			// asigna la palabra del mendaje y la comision en numero decimal

			switch (ventas)
			{
				case >= 50000:
					msg = "Excelente";
					comision = .1;
					break;
                case >= 20000:
                    msg = "Aceptable";
					msg = "Excelente";
                    comision = .07;
                    break;
                case >= 0:
                    msg = "Bajo";
					comision = 0;
                    break;
				default:
					break;
            }

			// Se eimprime el mensaje concadenado por el signo +

			Console.WriteLine(nombre + ", tuviste un " + msg + " Rendimiento, tu resumen es el siguiente");

			// se concadena texto con numero

			Console.WriteLine("Total de ventas: $" + ventas);

            // se concadena texto con la comision multiplicada por 100

            Console.WriteLine("Comision: "+ (comision*100) + "%");

            // se concadena texto con las ventas multiplicada por la comision

            Console.WriteLine("Comision Obtenida: $" + (ventas*comision));

			// se lee tecla para terminar

			Console.ReadKey();
        }
    }
}

