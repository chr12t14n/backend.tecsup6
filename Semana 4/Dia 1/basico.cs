using System;

namespace MiPrimeraAplicacion
{
   class Program
   {
      static void Main(string[] args)
      {
         
         // int , string , float , bool, char, decimal, double
         string nombre;
         int y;
         Console.WriteLine("Ingresa tu nombre");
         nombre = Console.ReadLine();
         // FORMAS DE IMPRIMIR POR CONSOLA
         Console.WriteLine($"Hello {nombre}!");
         Console.WriteLine("Hello " + nombre + "!");
         Console.WriteLine("Hello {0}!", nombre);
         // \n Salto de linea
         Console.Write("Texto\n");
         // \t Tabulación
         Console.Write(" mas\ttexto");
         // Conversiones de string a lo que necesitemos
         int x = int.Parse(Console.ReadLine());
         char c = char.Parse(Console.ReadLine());
         float f = float.Parse(Console.ReadLine());

         if (x > 17 && x >0)
         {
            Console.WriteLine($"Tienes {x} años, eres mayor.");
         }
         else
         {
            Console.WriteLine($"Tienes {x} años, eres un niño.");
         }
         
         
         

      }
   }
}
