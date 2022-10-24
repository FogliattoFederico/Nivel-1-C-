using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        { int numero, estado;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el estado");
            estado = int.Parse(Console.ReadLine());

            PositivoNegativoCero(numero, ref estado);

            Console.WriteLine("El estado del valor " + numero + " es : " + estado);
            
        }

        static void PositivoNegativoCero (int a, ref int b)
        {
        
        if (a == 0)
        
            b = 0;

        else if (a > 0)
        
            b = 1;

        else
    
            b = -1;
        
        }
    }
}
