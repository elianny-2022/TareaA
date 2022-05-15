using System;

namespace Cap4Ejer5
{			
 class Program
{
	public static void Main(string[] args)
	{
		
		Console.WriteLine("Ingrese la cantidad de personas: ");
		byte personas  = byte.Parse(Console.ReadLine());
		 
		int promedio = 0;
		 
		for (int i = 1; i <= personas; i++)
		{
			Console.Write("Ingrese la edad {0}: ", i);
			promedio += int.Parse(Console.ReadLine()); 
		}
		
		promedio = promedio / personas; 
		Console.WriteLine("La edad promedio: {0}", promedio); 
	}
}
}