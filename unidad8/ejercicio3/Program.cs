using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
          int n, con = 0, acup = 0, promedio, resultado;

          Console.WriteLine("Ingrese un numero");
          n = int.Parse(Console.ReadLine());

          while (n != 0)
          {
            resultado = primo(n);

            if (resultado == 1)
            {
               con++;
               acup += n; 
            }

          Console.WriteLine("Ingrese otro numero");
          n = int.Parse(Console.ReadLine());

          }  

          promedio = acup / con;

          Console.WriteLine("El promedio de primos es de : " + promedio);


        }
    
        static int primo(int n){

        int conp = 0;

        for (int x = 1; x <= n; x++)
        {
            if (n % x == 0)
            {
                conp++;
            }
        }
           
            if (conp == 2)
            {
                return 1;
            
            }else{
                return 0;
            }
        
        }
    }
}
