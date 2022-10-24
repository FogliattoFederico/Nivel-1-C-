using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, Mayor = 0, Menor = 0, bp = 0, bi = 0;

            for (int x = 0; x < 20; x++)
            {

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                if (bp == 0)
                {
                    Mayor = n;
                    bp = 1;
                }
                else if (n > Mayor)
                {
                    Mayor = n;
                }
            } 
            else
            {
                if (bi == 0)
                {
                    Menor = n;
                    bi = 1;
                }
                else if (n < Menor)
                {
                    Menor = n;
                }
            }
            
            }

            Console.WriteLine("El mayor par es : " + Mayor + " y el menor impar es : " + Menor);
            Console.WriteLine("FIN DEL PROGRAMA");
        
         }
    }
}
