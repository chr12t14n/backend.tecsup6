using System;

namespace MiPrimeraAplicacion
{
   class Program
   {
      static void Main(string[] args)
      {
         int num1 = int.Parse(Console.ReadLine());
         int num2 = int.Parse(Console.ReadLine());
         char operador = char.Parse(Console.ReadLine());

         switch (operador)
         {
            case '+':
               Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
               break;
            case '-':
               Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
               break;
            case '*':
               Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
               break;
            case '/':
               if (num2 == 0)
               {
                  Console.WriteLine("No se puede dividir por cero");
                  break;
               }
               Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
               break;
            default:
               break;
         }

      }
   }
}
