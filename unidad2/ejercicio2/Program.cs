using System;

namespace ejercicio_dos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resultado;

            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            resultado = n1 * n1 * n1;
            Console.WriteLine("el resultado es " + resultado);


        }
    }
}
