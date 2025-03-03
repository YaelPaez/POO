using System;
namespace Tarea1
{
	public class Ejercicio04
	{
		static void Main(string[] args)
		{
			// Declaro variables

			string calificacion;

			// Escribo en consola que hace la app y que tiene que
			// ingresar el usuario

			Console.WriteLine("Dime tu calificacion en una palabra");
			Console.WriteLine("- Excelente");
			Console.WriteLine("- Bueno");
			Console.WriteLine("- Regular");
			Console.WriteLine("- Malo");

			// Leo la consola y gurdo directamente el dato ya q es
			// tipo STRING

			calificacion = Console.ReadLine();

			// Convierto la cadena de texto a minusculas con ToLower
			// para que en el SWITCH no tome la palabra por tener
			// mayusculas o minusculas en la palabra

			calificacion = calificacion.ToLower();

			// Con el SWITCH imprime el mensaje de acuerdo con la
			// palabra en minusculas
			// y el DEFAULT dira que no se entienden las palabras
			// mal escritas o si son otras que no sean validas

			switch (calificacion)
			{
				case "excelente":
					Console.WriteLine("Wow, es asombroso, sigue asi!");
					break;
                		case "bueno":
                    			Console.WriteLine("Vamos! Tu puedes lograr mas");
					break;
                		case "regular":
                    			Console.WriteLine("Vas bien, solo esfuerzate un poco mas");
                    			break;
                		case "malo":
                    		Console.WriteLine("Con Esfuerso lo lograras, no te rindas!");
					break;
				default:
					Console.WriteLine("Disculpa, no te entendi");
					break;
            		}

			Console.ReadKey();

        	}
	}
}

