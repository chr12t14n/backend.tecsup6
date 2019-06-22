using System;

namespace MiPrimeraAplicacion
{
   class Program
   {
      static void Main(string[] args)
      {
         
         Console.WriteLine("1 Ripley");
         Console.WriteLine("2 Saga");
         Console.WriteLine("3 BCP");
         //int opcion = int.Parse(Console.ReadLine());
         string opc = Console.ReadLine();
         double monto = double.Parse(Console.ReadLine());
         switch (opc)
         {
            case "ripley":
               monto = monto - monto * 0.15;
               break;
            case "saga":
               monto = monto - monto * 0.2;
               break;
            case "BCP":
               monto = monto - 10;
               break;
            default:
               Console.WriteLine("No tiene tarjeta");
               break;
         }
         Console.WriteLine($"Debe pagar: {monto}");

      }
   }
}
