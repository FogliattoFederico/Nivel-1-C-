using System;

namespace ejercicio4a
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] acu = new int [15];
            int Cantidad = 0, Articulo = 0, max  = acu[0];

            Console.WriteLine("Ingrese numero de Articulo");
            Articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida");
            Cantidad = int.Parse(Console.ReadLine());
        

            for (int x = 0; x < 15; x++)
            {
            acu [x] = 0;
            } 
        
        
            while (Articulo != 0)
            {

            acu [Articulo - 1] += Cantidad;
             
            Console.WriteLine("Ingrese numero de Articulo");
            Articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida");
            Cantidad = int.Parse(Console.ReadLine());
        
            }

            for (int x = 0; x < 15; x++)
            {
                if (acu [x] > max)
                {
                    max = acu [x];
                    Articulo = x + 1;
                }
            }

            Console.WriteLine("El numero de articulo mas vendidio fue : " + Articulo);

            for (int x = 0; x < 15; x++)
            {
                if (acu [x] == 0)
                {
                    Articulo = x + 1;
                    Console.WriteLine("Los articulos que no registraron ventas son : " + Articulo);
                }

            }

            Console.WriteLine("La cantidad de ventas para el articulo 10 fue de : " + acu[9]);        
        
        
        
        }
        
    }
}
