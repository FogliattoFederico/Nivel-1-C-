using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [10];
            int max = numeros[0], pos = 1;
            

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                numeros[x] = int.Parse(Console.ReadLine());

                
            }
        
            for (int x = 0; x < 10; x++)
            {
              if (numeros [x] > max)
              {
                max = numeros[x];
                pos = x + 1;
              } 
            }    
        
            Console.WriteLine("El valor maximo es : " + max);
            Console.WriteLine("La posicion es : " + pos);

        

        
        }

    }
}
