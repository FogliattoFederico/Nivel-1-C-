using System;

namespace ejercico2
{
    class Program
    {
        static void Main(string[] args)
        {
            float litros, ImporteTotal;

            Console.WriteLine("Ingrese monto total");
            ImporteTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidas de litros");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500)
                ImporteTotal *= 0.75F;
            else
                if(litros > 300)
                    ImporteTotal *= 0.85F;
                else
                    if(litros > 100)
                        ImporteTotal *= 0.90F;
            
             

            Console.WriteLine("El monto a pagar es de " + ImporteTotal);
            Console.WriteLine("FIN DEL PROGRAMA");


        }       
    }
}
