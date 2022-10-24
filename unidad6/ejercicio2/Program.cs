using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
         int n, conimpar, congeneral, ngrupo = 0, min, contadorgrupos = 0;
         double porcentaje, porcentajemax = 0;
         bool banderaOrdenados = true;

         for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                congeneral = 0;
                conimpar = 0;

                min = n;

                while (n != 0)
                {
                    congeneral++;

                    if (n % 2 != 0)
                    {
                        conimpar++;
                    }

                    if (n <= min)
                    {
                        min = n;
                    }
                    else
                    {
                      banderaOrdenados = false;  
                    }

                    Console.WriteLine("Ingrese otro numero");
                    n = int.Parse(Console.ReadLine());

                    
                }

                porcentaje = conimpar * 100 / congeneral;

                if (porcentaje > porcentajemax)
                {
                    porcentajemax = porcentaje;
                    ngrupo = x + 1;

                }

                if (banderaOrdenados)
                {
                    contadorgrupos++;
                }
               
                Console.WriteLine("El porcentaje de negativos del grupo es " + porcentaje);
                
            }   

            Console.WriteLine("El grupo con mayor porcentaje de negativos es : " + ngrupo);
            Console.WriteLine("La cantidad de grupos ordenados es de : " + contadorgrupos);
            Console.WriteLine("FIN DEL PROGRAMA");

            
        }
    }
}
