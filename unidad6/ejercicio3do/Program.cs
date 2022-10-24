using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
             int n, con;

            do
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                con = 0;
               
                while (n > 0)
                {
                   con++;


                    Console.WriteLine("Ingrese un numero");
                    n = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("La cantidad de numeros en este grupo es de : " + con);
            
            
            } while (n >= 0);

            Console.WriteLine("FIN DEL PROGRAMA");

            




        }
    }
}
