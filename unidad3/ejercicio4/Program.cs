using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
          int a, b, c, d, menor;

          Console.WriteLine("Introducir un numero");  
          a = int.Parse(Console.ReadLine());
          Console.WriteLine("Introducir un numero");
          b = int.Parse(Console.ReadLine());
          Console.WriteLine("Introducir un numero");  
          c = int.Parse(Console.ReadLine());
          Console.WriteLine("Introducir un numero");  
          d = int.Parse(Console.ReadLine());
          
          if(a < b)
            menor = a;
          else
            menor = b;
          
          if(c < menor)
            menor = c;
          
          if(d < menor)
            menor = d;

          Console.WriteLine("El menor es " + menor);
          Console.WriteLine("Fin dek programa");  
             
          

            

        
        }



    }
}
