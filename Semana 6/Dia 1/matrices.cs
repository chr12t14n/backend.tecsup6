using System;

namespace zxcvzxcvzvcx
{
   class Program
   {
      static void Main(string[] args)
      {         
         int[,] matriz = new int[10, 5];
         matriz[0, 0] = 100;
         matriz[0, 1] = 55;
         int[,] matrizConValores =
         {
            { 4 ,5 ,2 },
            { 8 ,5 ,6 },
            { 8 ,2 ,1 },
            { 0 ,4 ,3 }
         };
         Console.WriteLine();

         for (int filas = 0; filas < matrizConValores.GetLength(0); filas++)
         {
            for (int col = 0; col < matrizConValores.GetLength(1); col++)
            {
               Console.Write(matrizConValores[filas,col] + "  ");
            }
            Console.WriteLine();
            
         }
         int[,] mat = new int[3, 3];

         for (int filas = 0; filas < mat.GetLength(0); filas++)
         {
            for (int col = 0; col < mat.GetLength(1); col++)
            {
               mat[filas, col] = int.Parse(Console.ReadLine());
            }
         }

         for (int filas = 0; filas < mat.GetLength(0); filas++)
         {
            for (int col = 0; col < mat.GetLength(1); col++)
            {
               Console.Write(mat[filas, col] + "  ");
            }
            Console.WriteLine();
         }
         

         int[,] matriz1 =
         {
            { 4 ,5 ,2 ,3,2 },
            { 8 ,5 ,6 ,9,2},
            { 8 ,2 ,1 ,5,3},
            { 0 ,4 ,3 ,5,5},
            { 8 ,5 ,6 ,9,2}
         };
         ImprimirMatriz(matriz1);
         
         int[,] matriz2 =
         {
            { 3 ,5 ,2 ,2,2 },
            { 8 ,2 ,6 ,7,2},
            { 7 ,2 ,2 ,2,3},
            { 3 ,4 ,3 ,5,2},
            { 8 ,7 ,6 ,9,2}
         };
         ImprimirMatriz(matriz2);

         int[,] matrizResultado = SumarMatrices(matriz1, matriz2);
         ImprimirMatriz(matrizResultado);

         matrizResultado = MultiplicarMatriz(matrizResultado, 5);
         ImprimirMatriz(matrizResultado);

      }

      static void ImprimirMatriz (int [,] matriz)
      {
         for (int filas = 0; filas < matriz.GetLength(0); filas++)
         {
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
               Console.Write(matriz[filas, col] + "  ");
            }
            Console.WriteLine();
         }
         Console.WriteLine();
      }

      static int[,] SumarMatrices(int [,] primeraMatriz, int [,] segundaMatriz)
      {
         int fil = primeraMatriz.GetLength(0);
         int columnas = primeraMatriz.GetLength(1);
         int[,] matrizResultado = new int[fil, columnas];

         for (int filas = 0; filas < primeraMatriz.GetLength(0); filas++)
         {
            for (int col = 0; col < primeraMatriz.GetLength(1); col++)
            {
               matrizResultado[filas,col] = primeraMatriz[filas,col] 
                  + segundaMatriz[filas,col];
            }
         }
         return matrizResultado;
      }

      static int[,] MultiplicarMatriz(int [,] matriz, int numero)
      {
         int[,] matrizResultado = new int[matriz.GetLength(0), matriz.GetLength(1)];
         for (int filas = 0; filas < matriz.GetLength(0); filas++)
         {
            for (int col = 0; col < matriz.GetLength(1); col++)
            {
               matrizResultado[filas, col] = matriz[filas, col] * numero;
            }
         }
         return matrizResultado;
      }
   }
}

