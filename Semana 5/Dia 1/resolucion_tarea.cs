using System;

namespace FuncionesNoche
{
   class Program
   {
      static void Main(string[] args)
      {
         //Imprimir suma de los números intermedios de dos números
         /*
         int num1 = int.Parse(Console.ReadLine());
         int num2 = int.Parse(Console.ReadLine());
         int suma = 0;
         for (int i = num1+1; i < num2; i++)
         {
            suma = suma + i;
         }
         Console.WriteLine($"La suma de los elementos es: {suma}");
         */
         int[] arreglo = { 45, 20000, 45, 2, 3, 3, 9, 10 };
         //Sumar los elementos
         /*
         int suma = 0;
         
         int media = 0;
         // tambien se puede usar un foreach
         for (int i = 0; i < arreglo.Length; i++)
         {
            suma = suma + arreglo[i];
         }
         foreach (var item in arreglo)
         {
            Console.Write(item + "  ");
         }
         media = suma / arreglo.Length;
         Console.WriteLine($"La suma de los elementos del arreglo es: {suma}");
         Console.WriteLine($"La media de los elementos del arreglo es: {media}");
         */
         //Obtener el elemento más grande
         /*
         int mayor = 0;
         for (int i = 0; i < arreglo.Length; i++)
         {
            if (arreglo[i] > mayor)
            {
               mayor = arreglo[i];
            }
         }
         Console.WriteLine($"El mayor es: {mayor}");
         */
         //Copia de un arreglo a otro
         /*
         int tam = arreglo.Length;
         int[] arregloParaCopiar = new int[tam];
         for (int i = 0; i < tam; i++)
         {
            arregloParaCopiar[i] = arreglo[i];
         }
         
         Console.WriteLine("Se copió el arreglo:");
         foreach (var item in arregloParaCopiar)
         {
            Console.Write(item + "  ");
         }
         */
         //Revertir el arreglo


         /*

         //Insertar N elementos de la numeración Fibonacci
         // 0 1 1 2 3 5 8 13 21 34
         int N = int.Parse(Console.ReadLine());
         int[] arrFibonacci = new int[N];
         arrFibonacci[0] = 0;
         arrFibonacci[1] = 1;

         //SIN ARREGLOS
         //int primero = 0;
         //int segundo = 1;
         //int siguiente;
         //Console.Write(primero + "  " + segundo +" ");
         for (int i = 2; i < N; i++)
         {
            arrFibonacci[i] = arrFibonacci[i-1] + arrFibonacci[i-2];

            //SIN ARREGLOS
            //siguiente = primero + segundo;
            //Console.Write(siguiente + " ");
            //primero = segundo;
            //segundo = siguiente;
         }

         ImprimirArreglo(arrFibonacci);
         ImprimirArreglo(arreglo);
         */
	 
      }
   }
}