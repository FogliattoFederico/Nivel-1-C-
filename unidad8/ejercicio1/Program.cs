using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2 = int.Parse(Console.ReadLine());
        
            resultado = Producto(n1 , n2);
        
            Console.WriteLine("El resultado del producto es " + resultado);
        }


        static int Producto(int a , int b){

        int r = a * b;
        
        return r;
        }

    
    }
}
