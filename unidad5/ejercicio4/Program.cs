﻿using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {
            if (n % x == 0)
            {
               con ++; 
            }
                
            }

            if (con == 2)
            {
                Console.WriteLine("El Numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }

            Console.WriteLine("FIN DEL PROGRAMA");


        }
    }
}
