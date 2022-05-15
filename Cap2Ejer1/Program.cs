using System;
using System.Collections.Generic;
using System.Text;
using System.String;


namespace Cap2Ejer1
{
    class Program
    {
        static void Main(string[] args){
            string valor = "";
            float N = 1.0f;
            float L = 1.0f;
            float perimetro = 0.0f;

            Console.Write("Dame el numero de lados: ");
                valor = Console.ReadLine();
                N = Convert.ToSingle(valor); 
            Console.Write("Dame la longitud de sus lados: ");
                valor = Console.ReadLine();
                L = Convert.ToSingle(valor); 

                perimetro = N * L;
                Console.WriteLine("El perímetro es : {0} unidades", perimetro);
        }
        
    }
    
}