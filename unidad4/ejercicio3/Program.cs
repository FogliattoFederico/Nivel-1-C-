using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Procesador, Memoria, Disco;
            float precio = 0;
        

            Console.WriteLine("Elija la opcion de procesador1 : 1- I5, 2- I7, 3-I9");
            Procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija la opcion de memoria ram : 1- 8GB, 2- 16GB, 3- 32GB");
            Memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea extender su disco 1- SI, 2- NO");
            Disco = int.Parse(Console.ReadLine());

           switch (Procesador)
           {
                case 1:
                    switch (Memoria)
                    {
                        case 1:
                            precio = 800;
                            break;
                        case 2:
                            precio = 900;
                            break;
                        default:
                            precio = 1000;
                            break;
                    }   
                    break;
                case 2:
                    switch (Memoria)
                    {
                        case 1:
                            precio = 900;
                            break;
                        case 2:
                            precio = 1000;
                            break;
                        default:
                            precio = 1400;
                            break;
                    }
                    break;
                case 3:
                    switch (Memoria)
                    {
                        case 1:
                            precio = 1200;
                            break;
                        case 2:
                            precio = 1400;
                            break;
                        default:
                            precio = 2000;
                            break;
                    }
                    break;  
                default:
                break;
            }
           
           if(Disco == 1)
                precio = precio + 300;
            
           
            Console.WriteLine("El importe de la computadora es " + precio + "USD");
            
            
        }
    }
}
