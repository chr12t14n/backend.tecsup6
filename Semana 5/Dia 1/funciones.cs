using System;

namespace Funciones
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine(MostrarMayor(3,4));
        int [] arr = new int [4];
        ImprimirArreglo(arr);
      } 
            
      static int Multiplicar(int x, int y)
      {
         int suma = 0;
         for (int i = 0; i < y; i++)
         {
            suma += x;
         }
         return suma;
      }

      static void ImprimirArreglo(int [] arr)
      {
         foreach (var item in arr)
         {
            Console.Write(item + " ");
         }
      }


      static int MostrarMayor(int numero1, int numero2 = 10)
      {
         if (numero1 > numero2)
         {
            //Console.WriteLine("El mayor es: {0}", numero1);
            return numero1;
         }
         else
         {
            //Console.WriteLine("El mayor es: {0}", numero2);
            return numero2;
         }
      }
   }
}