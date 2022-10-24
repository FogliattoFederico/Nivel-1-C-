using System;

namespace TFFinal_Fogliatto
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa 
        // un cero. A partir de dichos datos informar:

        // a. El mayor de los números pares.
        // b. La cantidad de números impares.
        // c. El menor de los números primos.

        // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que 
        // devuelva true o false según corresponda.
           
           int n, maxPar = 0, contimp = 0, resultado, bm = 0, menor = 0;

           Console.WriteLine("Ingrese un numero");
           n = int.Parse(Console.ReadLine());  

           while (n != 0)
           {
            if (n % 2 == 0)
                {
                if (n > maxPar)
                {
                maxPar = n;
                } 
            }else
                contimp++;

            resultado = primo(n);

            if (resultado == 1)
            {
                if (bm == 0)
                {
                    menor = n;
                    bm = 1;
                
                }else{
                    if (n < menor)
                    {
                    menor = n;
                    }
                }
            }

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());  


           }
        
            Console.WriteLine("El mayor de los pares es : " + maxPar);
            Console.WriteLine("El contador impar es de : " + contimp);
            Console.WriteLine("El menor de los primos es : " + menor);
        
        
        }
    
        static int primo(int n)
        {   int conPrimo = 0;

            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                {
                conPrimo ++;  
                }
            }

            if (conPrimo == 2)
            {
                return 1;
            }else
            {
                return 0;
            }
    
        }   
        
    }
}
