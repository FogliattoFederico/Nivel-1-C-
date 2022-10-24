using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, b, resultado = 0;
           
           Console.WriteLine("Ingrese Un Numero");
           a = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese otro numero");
           b = int.Parse(Console.ReadLine());

          // alternativa 1
          
           //if(a > b)
               // resultado = a - b;

            //if(a == b)
              //  resultado = a + b;
            
            //if(a < b)
              //  resultado = a * b;

            
            // alternativa 2
            
            //if(a > b)
                //resultado = a - b;
                 
            //else
                //if(a < b)
                  //  resultado = a * b;
                     
                 //else
                   // resultado = a + b;
                     
            
            
            // alternativa 3

            if(a > b)
                resultado = a - b;
                 
            else if(a < b)
                resultado = a * b;
                     
            else
                resultado = a + b;
                     
            
            
            
            Console.WriteLine("el resultado es: " + resultado);


        }
    }
}
