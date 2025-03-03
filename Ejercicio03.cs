using System;
namespace Tarea1
{
	public class Ejercicio03
	{
		static void Main(string[] args)
		{
			// desclaro variables

			double L1, L2, L3;
			string tipo;

		        // Indico el objetivo de la aplicacion y pido los datos
		        // que se requieren
		
		        Console.WriteLine("te dire que tipo de trangulo es");

			Console.WriteLine("Intruduce la medida del primer lado");

            		// En este caso va a leer el dato con Console.ReadLine(),
            		// pero como lo declare como tipo double, lo tenemos que
            		// covertir a double con double.Parse(), y el dato ya leido
			// y convertido a double ahora si se puede almacenar 

		        L1 = double.Parse(Console.ReadLine());
		
		        Console.WriteLine("Intruduce la medida del segundo lado");
		        L2 = double.Parse(Console.ReadLine());
		
		        Console.WriteLine("Intruduce la medida del tercer lado");
		        L3 = double.Parse(Console.ReadLine());

			// por medio de un IF ELSE, haho las pruebas logicas
			// para despues guardar en la var <tipo> el valor a, b o c,
			// que correspoonden a un tipo de rectangulo

			// Si lado1 es igual a lado2 y si a la vez lado2 es igual
			// al lado3
			if (L1 == L2 && L2 == L3)
				{
					tipo = "a";
				}
				// O Si lado1 es igual1 a lado2, o si lado2 es igual a lado3,
				// o si lado3 es igual3 a lado1
				else if (L1 == L2 || L2 == L3 || L3 == L1)
					{
						tipo = "b";
					}
					// o en caso que no se cumplan las dos anteriores
					else
					{
						tipo = "c";
					}

			// con SWITCH, imprimo en consoola el mensaje de acuerdo al
			// valor que tiene la var <tipo>

			switch (tipo)
			{
				case "a":
				    Console.WriteLine("El triangulo es equilatero");
				    break;
		                case "b":
		                    Console.WriteLine("El triangulo es isoceles");
		                    break;
		                case "c":
		                    Console.WriteLine("El triangulo es escaleno");
		                    break;
				default:
				    break;
            	       }

		       // se espera a que el usuario oprima cualquier tecla para
		       // finalizar la ejecucion de la app

			Console.ReadKey();
        	}
	}
}

