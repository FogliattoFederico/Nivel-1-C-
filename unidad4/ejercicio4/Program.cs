using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, suma, producto;

            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            c = int.Parse(Console.ReadLine());
 
            suma = a + b;

            producto = b * c;

            if(suma > producto)
                Console.WriteLine("Es mayor");
            else   
                Console.WriteLine("No es mayor");
            
                

            Console.WriteLine("FIN DEL PROGRAMA");

        
        
        
        }
    }
}
