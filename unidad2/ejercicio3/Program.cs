using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
          int km, vel, tiempo;

          Console.WriteLine("Introducir Distancia");
          km = int.Parse(Console.ReadLine());
          Console.WriteLine("Introducir Velocidad");
          vel = int.Parse(Console.ReadLine());

          tiempo = km / vel;
          Console.WriteLine("El tiempo estimado para llegar en horas es de " + tiempo);

        }
    }
}
