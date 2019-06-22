using System;

namespace MiPrimeraAplicacion
{
   class Program
   {
      static void Main(string[] args)
      {
         // SUMA DE ELEMENTOS EN UN RANGO
         /*
         int num1 = int.Parse(Console.ReadLine());
         int num2 = int.Parse(Console.ReadLine());
         int suma = 0;
         for (int i = num1; i <= num2; i++)
         {
            suma += i; // suma = suma + i;
         }
         Console.WriteLine($"La suma de los elementos es {suma}");
         */

         // MULTIPLICACIÓN SIN USAR EL OPERADOR *
         /*
         int num1 = int.Parse(Console.ReadLine());
         int num2 = int.Parse(Console.ReadLine());
         int resultado = 0;
         for (int i = 1; i <= num1; i++)
         {
            resultado = resultado + num2;
         }
         */
         // MOSTRAR TABLA DE MULTIPLOS
         /*
         for (int i = 1; i <= 10; i++)
         {
            for (int j = 1; j <= 10; j++)
            {
               Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
         }
         */
         // MATRIZ IDENTIDAD
         /*
         Console.WriteLine("Indicar tamaño de matriz");
         int N = int.Parse(Console.ReadLine());
         for (int i = 0; i < N; i++)
         {
            for (int j = 0; j < N; j++)
            {
               if (i == j)
                  Console.Write("1 ");
               else
                  Console.Write("0 ");
            }
            Console.WriteLine();
         }
         */
         // TRIANGULO_PARED
         /*
         Console.WriteLine("Indicar tamaño del triangulo");
         int N = int.Parse(Console.ReadLine());

         for (int filas = 1; filas <= N; filas++)
         {
            for (int col = 1; col <= filas; col++)
            {
               Console.Write($"{col} ");
            }
            Console.Write("\n");
         }

         for (int filas = N-1; filas > 0; filas--)
         {
            for (int col = 1; col <= filas; col++)
            {
               Console.Write($"{col} ");
            }
            Console.Write("\n");
         }
         */
         // TRIANGULO CON UN SOLO FOR ANIDADO
         Console.WriteLine("Indicar tamaño del triangulo");
         int N = int.Parse(Console.ReadLine());
         int altura = N * 2 - 1;
         bool creciendo = true;
         int elementos = 1;
         for (int filas = 1; filas <= altura; filas++)
         {
            for (int col = 1; col <= elementos; col++)
            {
               Console.Write($"{col} ");
            }
            if (N == elementos)
               creciendo = false;
            if (creciendo)
            {
               elementos++;
            }
            else
            {
               elementos--;
            }

            Console.Write("\n");
         }

         // FACTORIAL
         /*
         int N = int.Parse(Console.ReadLine());
         long factorial = 1;

         for (int i = 1; i <= N; i++)
         {
            factorial = factorial * i;
         }
         Console.WriteLine($"El factorial es: {factorial}");
         */



      }
   }
}
