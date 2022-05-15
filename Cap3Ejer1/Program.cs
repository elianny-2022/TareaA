using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Escribe un número: ");
            long numero = Convert.ToInt64(Console.ReadLine());
            long sobrante = numero % 2;
            if (sobrante == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
          
            }
          
        }
    }
}