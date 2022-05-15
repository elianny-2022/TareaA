using System;

namespace Cap3Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float opcion = 0.0f;
            string valor = "";
            float N = 1.0f;
            float L = 1.0f;
            float ap = 1.0f;
            float perimetro = 0.0f;
            float area = 0.0f;

            Console.WriteLine("Desea calcular el area[1] o el perimetro [2] ");
             valor = Console.ReadLine();
              opcion = Convert.ToSingle(valor); 
            if (opcion == 1)
            {
                 Console.Write("Dame el numero de lados: ");
                valor = Console.ReadLine();
                N = Convert.ToSingle(valor); 
                Console.Write("Dame la longitud de sus lados: ");
                valor = Console.ReadLine();
                L = Convert.ToSingle(valor); 

                perimetro = N * L;
                Console.WriteLine("El perímetro es : {0} unidades", perimetro);
            }
            else if(opcion == 2)
            {
                 Console.Write("Dame el numero de lados: ");
                valor = Console.ReadLine();
                N = Convert.ToSingle(valor); 
                Console.Write("Dame la longitud de sus lados: ");
                valor = Console.ReadLine();
                L = Convert.ToSingle(valor); 
                Console.Write("Dame el apotema del poligono: ");
                valor = Console.ReadLine();
                ap = Convert.ToSingle(valor);

                area = (N * L * ap) / 2;
                Console.WriteLine("El area es : {0} unidades", area);
          
            }
        }
    }
}
