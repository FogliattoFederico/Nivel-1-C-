using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, resultado;

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            resultado = Par(n);

            if (resultado == 1)
            {
                Console.WriteLine("El numero es par");
            }else{
                Console.WriteLine("El nuemero no es par");
            }

            Console.WriteLine("FIN DEL PROGRAMA");

        }
    
    
    
        static int Par(int a){

            if (a % 2 == 0)
            {
                return 1;
                 
            }else
            {
                return 0;
                
            }
        }
    
    
    }
}
