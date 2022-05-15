using System;
using System.Collections.Generic;
using System.Text;



namespace Cap2Ejer1
{
    class Program
    {
        static void Main(string[] args){
            string valor = "";
            float dolar = 1.0f;
            float euro = 1.0f;
            float tasaD = 0;
            float tasaE= 0;
            float ResultadoD = 0.0f;
            float ResultadoE = 0.0f;

             Console.Write("Ingrese tasa del dia de dolares: ");
                valor = Console.ReadLine();
                tasaD = Convert.ToSingle(valor);
                Console.Write("Ingrese tasa del dia de dolares: ");
                valor = Console.ReadLine();
                tasaE = Convert.ToSingle(valor); 

            Console.Write("Cantidad de dolares: ");
                valor = Console.ReadLine();
                dolar = Convert.ToSingle(valor); 
            Console.Write("Cantidad de euro: ");
                valor = Console.ReadLine();
                euro= Convert.ToSingle(valor); 

                ResultadoD = tasaD*dolar;
                ResultadoE = tasaE*euro;
                Console.WriteLine("Cantidad de dolares que compro son: {0} dolares. Y cantidad de euro que compro son: {1} euros", ResultadoD, ResultadoE);
        }
        
    }
    
}

