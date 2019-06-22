using System;

namespace MiPrimeraAplicacion
{
   class Program
   {
      static void Main(string[] args)
      {
         int numero = int.Parse(Console.ReadLine());
         if ((numero > 99 && numero < 1000) ||
            (numero < -99 && numero > -1000))
         {
            Console.WriteLine("Numero de tres cifras");
         }
         else
            Console.WriteLine("No es de tres cifras");
      }
   }
}
