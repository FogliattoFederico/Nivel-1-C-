using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, promedio;

            Console.WriteLine("Introducir nota primer examen");
            n1 = int.Parse(Console.ReadLine());    
            Console.WriteLine("Introducir nota segundo examen");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir nota tercer examen");
            n3 = int.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("El promedio del alumno es de " + promedio);


       }
    }
}
