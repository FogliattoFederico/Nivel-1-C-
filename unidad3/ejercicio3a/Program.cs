using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           float importe, importefinal;

           Console.WriteLine("Ingrese el importe");
            importe = float.Parse(Console.ReadLine());

            if(importe >= 5000){
                importefinal = importe * 0.82F;
            }else{
                if(importe >= 1000)
                    importefinal = importe * 0.90F;
                else
                    importefinal = importe;
            }

            Console.WriteLine("El importe a cobrar es " + importefinal);
            Console.WriteLine("Fin del Programa");


        }

    }
}
