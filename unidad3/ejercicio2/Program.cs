using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());

            if(n > 0)
                Console.WriteLine("El numero es positivo");
            else
                Console.WriteLine("El numero es negativo");
            
            Console.WriteLine("Fin del programa");
                

        }
    }
}
