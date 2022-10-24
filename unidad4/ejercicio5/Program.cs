using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        int a, b, c, d;
        
        Console.WriteLine("Ingrese un numero");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero");
        d = int.Parse(Console.ReadLine());

        if(a > b && b > c && c > d)
            Console.WriteLine("estan ordenados");
        else
             Console.WriteLine("No estan ordenados");


        }
    }
}
