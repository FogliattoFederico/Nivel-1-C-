using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                
                if (x == 0)
                {
                   mayor = n;
                }
                else
                {
                    if (n > mayor)
                    {
                        mayor = n;
                    }
                } 
                
            }
            
            Console.WriteLine("El mayor es " + mayor);
            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}
