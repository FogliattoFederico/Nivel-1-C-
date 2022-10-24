using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, conp = 0;

            for (int x = 0; x < 10; x++)
            {
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine()); 

                con = 0;
                
                for (int y = 1; y <= n; y++)
                {
                  if (n % y == 0)
                  {
                    con ++;
                  }   
                }
            
                if (con == 2)
                {
                  conp ++;  
                }
            }

            Console.WriteLine("La cantidad de numeros primos es " + conp);
            Console.WriteLine("FIN DEL PROGRAMA");






        }
    }
}
