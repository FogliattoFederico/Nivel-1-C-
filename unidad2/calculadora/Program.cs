using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //paso 0: determina variables
            int n1, n2, resultado;
            
            //paso 1: pedir valores
            Console.WriteLine("pida un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("pida otro numero");
            n2 = int.Parse(Console.ReadLine());

            //paso 3: realizar el calculo
            resultado = n1 + n2; 
           
           //paso 3: mostrar resultado
           Console.WriteLine("el resultado de la operacion es " + resultado);   
        }
    }
}
