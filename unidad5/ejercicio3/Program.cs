﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, promedio = 0, acu = 0, con = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad");
                edad = int.Parse(Console.ReadLine());
                
                if (edad > 18)
                {
                    acu += edad;
                    con ++;
                }
            }

            promedio = acu / con;

            Console.WriteLine("El promedio es" + promedio);
            Console.WriteLine("FIN DEL PROGRAMA");

        }
    }
}
