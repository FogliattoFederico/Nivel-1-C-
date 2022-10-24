using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
        //    char letraActual, letraNueva, letra; 
        //    char [] frase = new char [30];
        //    int indice = 0;

        //    Console.WriteLine("Ingrese una letra para la frase");
        //    letra = char.Parse(Console.ReadLine());

        //    while (letra != '0' && indice < 30)
        //    {
        //         frase [indice] = letra;
        //         indice++;

        //         Console.WriteLine("Ingrese otra letra para la frase");
        //         letra  = char.Parse(Console.ReadLine());   
        //    }

        //     frase[indice] = '\0';

        //     Console.WriteLine("La frase completa es :");
        //     indice = 0;
        //     while (frase [indice] != '\0')
        //     {
        //         Console.Write(frase[indice]);
        //         indice++;
        //     }

        //     Console.WriteLine("Ingrese la letra a reemplazar");
        //     letraActual = char.Parse(Console.ReadLine());
        //     Console.WriteLine("Ingrese la nueva letra");
        //     letraNueva = char.Parse(Console.ReadLine());

        //     indice = 0;

        //     while (frase[indice] != '\0')
        //     {
        //         if (frase[indice] == letraActual)
                
        //             frase[indice] = letraNueva;
                
            
        //         indice++;
        //     }
           
        //     Console.WriteLine("La frase nueva es :");

        //     indice = 0;

        //     while (frase[indice] != '\0')
        //     {
        //         Console.Write(frase[indice]);
        //         indice++;
        //     }
       
        string frase;
        char letraActual, letraNueva;

        Console.WriteLine("Ingrese la frase");
        frase = Console.ReadLine();
        Console.WriteLine("Ingrese la letra a reemplazar");
        letraActual = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la nueva letra");
        letraNueva = char.Parse(Console.ReadLine());

        frase = frase.Replace(letraActual, letraNueva);

        Console.WriteLine("La nueva frase es : ");
        Console.WriteLine(frase);




        }
    }
}
