using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
 
        int n = 1, con;

        while (n >= 0)
        {
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            
            con = 0;

            while (n > 0)
            {
                con++;

                Console.WriteLine("Ingrese otro numero");
                n = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("La cantidad de numeros en este grupo es : " + con );
            
        }
        
        Console.WriteLine("FIN DEL PROGRAMA");

 
 
        
        
        
        
        
        
        }
    }
}
