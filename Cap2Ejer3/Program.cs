using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Cap2Ejer3 {
	
	static class Constans {
		
		public const double PI = 3.1416;

	}

	class Program {
		
		static void Main (string[] args){
			
			//Inicializamos las variables 
			double grados, radianes, resultado;
			string linea;
			int valor;

			//Solicitamos ingrese la opcion
			System.Console.WriteLine("Para convertir radianes ingrese 1 para convertir grados ingrese 2.");
			linea = Console.ReadLine();

			valor = Convert.ToInt32(linea);

			if (valor == 1){
				
				System.Console.WriteLine("Ingrese la cantidad de radianes a convertir, por favor.");
				linea = Console.ReadLine();

				radianes = Convert.ToDouble(linea);

				resultado = (radianes * 180) / Constans.PI;

				System.Console.WriteLine("Los radianes {0} equivalen a: {1} grados", radianes, resultado);
			}

			if (valor == 2){
				
				//Pedimos loos grados a convertir
			System.Console.WriteLine("Ingrese los grados a convertir, por favor.");
			linea = Console.ReadLine();

			grados = Convert.ToDouble(linea);

			//Convertimos los grados a radianes
			radianes = (grados * Constans.PI)/180;

			//Imprimimos el resultado
			System.Console.WriteLine("Los grados {0} en radianes equivale a: {1} radianes", grados, radianes);

			}

		}
	}
}
