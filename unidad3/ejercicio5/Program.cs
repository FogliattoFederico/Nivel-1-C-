using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, b, c, d;

           Console.WriteLine("Introducir un numero");
           a = int.Parse(Console.ReadLine());
           Console.WriteLine("Introducir otro numero");
           b = int.Parse(Console.ReadLine());
           Console.WriteLine("Introducir otro numero");
           c = int.Parse(Console.ReadLine());
           Console.WriteLine("Introducir ultimo numero");
           d = int.Parse(Console.ReadLine());

            if(a > 100)
                Console.WriteLine("El primer valor: " + a + " es mayor a 100.");
            
            if(b > 100)
                Console.WriteLine("El segundo valor: " + b + " es mayor a 100.");
                 
            if(c > 100)
                Console.WriteLine("El tercer valor: " + c + " es mayor a 100.");
                 
            if(d > 100)
                Console.WriteLine("El cuarto valor: " + d + " es mayor a 100.");
               
           Console.WriteLine("FIN DEL PROGRAMA");  

                   
                

         
        }
    }
}
