using System;
 
			
namespace Cap4Ejer1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number=0;
             
            Console.WriteLine("Introduce un número:");
            number=int.Parse(Console.ReadLine());
             
            for(int i=0; i<=10;i++)
            {
                Console.WriteLine(number+"x"+i+"="+(i*number));
            }
             
             
            Console.Write("pulsa cualquier letra para continuar . . . ");
            Console.ReadKey(true);
        }
    }
} 