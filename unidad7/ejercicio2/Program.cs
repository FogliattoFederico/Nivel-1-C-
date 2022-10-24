using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [10];
            int acu = 0, promedio = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                numeros [x] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < 10; x++)
            {
              acu += numeros[x];  
            }
        
            promedio = acu / 10;

        
           for (int x = 0; x < 10; x++)
            {
             if (numeros [x] > promedio)
               {
                Console.WriteLine("Este numero es mayor al promedio : " + numeros[x]);
               }
            }

            

        
        }


    }
}
