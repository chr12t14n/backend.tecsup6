using System;

namespace Funciones_1
{
   class Program
   {
      static void MostrarArreglo(int[] arreglo)
      {
         for (int i = 0; i < arreglo.Length; i++)
         {
            Console.Write(arreglo[i] + "  ");
         }
         Console.WriteLine();
      }

      static int[] Push(int n, int[] arr)
      {
         MostrarArreglo(arr);
         int[] arregloNuevo = new int[arr.Length + 1];
         for (int i = 0; i < arr.Length; i++)
         {
            arregloNuevo[i] = arr[i];
         }
         arregloNuevo[arregloNuevo.Length - 1] = n;
         arr = arregloNuevo;
         MostrarArreglo(arr);
         return arregloNuevo;

      }

      static void Main(string[] args)
      {
         int[] arreglo = { 6, 3, 5, 9, 2, 10, 32, 7 };
         int opcion;
         do
         {
            Console.WriteLine("****** MENU ******");
            Console.WriteLine("1 funcion push");
            Console.WriteLine("2 funcion pop");
            Console.WriteLine("3 ordenar el arreglo");
            Console.WriteLine("4 el arreglo es simetrico?");
            Console.WriteLine("5 quitar elemento por posicion");
            Console.WriteLine("6 salir");
            Console.WriteLine("\nIngrese una opcion");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
               case 1:
                  Console.WriteLine("\nIngrese un numero para hacer push");
                  int n = int.Parse(Console.ReadLine());
                  arreglo = Push(n, arreglo);
                  break;
               case 2:
                  //Pop();
                  break;
               case 3:
                  //OrdenarArreglo();
                  break;
               case 4:
                  //EsSimetrico();
                  break;
               case 5:
                  //QuitarElemento();
                  break;
               default:
                  break;
            }

         } while (opcion != 6);

      }
   }
}
