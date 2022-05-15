using System;

namespace Cap3Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            float i = 0f;

            Console.WriteLine("Escribe un número: ");
             valor = Console.ReadLine();
                i = Convert.ToSingle(valor); 
            if (i == 1)
            {
                Console.WriteLine("Lunes");
            }
            if(i == 2)
            {
                Console.WriteLine("Martes");
          
            }
            if(i == 3)
            {
                Console.WriteLine("Miercoles");
            }
            if(i == 4)
            {
                Console.WriteLine("Jueves");
            }
            if(i == 5)
            {
                Console.WriteLine("Viernes");
            }
            if(i == 6)
            {
                Console.WriteLine("Sabado");
            }
            if(i == 7)
            {
                Console.WriteLine("Domingo");
            }

        }
    }
}
