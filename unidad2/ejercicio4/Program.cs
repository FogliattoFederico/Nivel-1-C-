using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
           float tf, co, sf;

           Console.WriteLine("Introduzca total facturado por el empleado");
            tf = float.Parse(Console.ReadLine());
            co = tf * 5 / 100;
            sf = co + 15000; 
            Console.WriteLine("El sueldo a pagar es " + sf);

        }
    }
}
