using System;

namespace MiPrimeraAplicacion
{
   class Program
   {
      static void Main(string[] args)
      {
         // tabla de multiplicar del 9
         for (int i = 1; i <= 12 ; i++)
         {
            Console.WriteLine($"{i} * 9 = {i * 9}");
         }
         
         for (int i = 0, c = 0; ; i++)
         {
            if (i % 2 != 0)
            {
               Console.Write(i);
               c++;
            }
            if (c == 20)
               break;
         }

         for (int i = 1; i <= 20; i++)  // i+=2  === i  = i + 2
         {
            Console.Write($"{i * 2 - 1} ");
         }

         int N = int.Parse(Console.ReadLine());
         int sumaMultiplos = 0;
         // imprime los N primeros números multiplos de 3
         for (int i = 1; i <= N; i++)  
         {
            sumaMultiplos = sumaMultiplos + (i * 3);
         }
         Console.WriteLine($"\n{sumaMultiplos}");
      }
   }
}
