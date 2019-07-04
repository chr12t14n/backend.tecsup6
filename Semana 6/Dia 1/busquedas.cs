using System;

namespace zxcvzxcvzvcx
{
   class Program
   {
      static void Main(string[] args)
      {
         /*
         //DECLARACION DE VARIABLES
         int N1, N2, N3, mayor, menor;
         //INICIALIN3ACION DE VARIABLES
         N1 = int.Parse(Console.ReadLine());
         N2 = int.Parse(Console.ReadLine());
         N3 = int.Parse(Console.ReadLine());
         //COMPARACIONES
         if (N1 > N2 && N1 > N3)
         {
            mayor = N1;
            // Console.WriteLine("El mayor es "+ N1);
         }
         else if (N2 > N3)
            mayor = N2;
         else
            mayor = N3;

         if (N1 < N2 && N1 < N3)
         {
            menor = N1;
         }
         else if (N2 < N3)
            menor = N2;
         else
            menor = N3;
         Console.WriteLine($"El mayor es {mayor} y el menor es {menor}");
         */

         // SABER SI UN NUMERO TIENE 3 DIGITOS  100-999

         // CUAL ES EL ULTIMO DIGITO DE UN NUMERO
         /*
         int numero = int.Parse(Console.ReadLine());
         int respuesta;
         respuesta = numero % 10;
         Console.WriteLine("El último digito del numero es " + respuesta);
         */

         // SABER CUÁNTOS DIGITOS TIENE UN NUMERO
         /*
         int numero = int.Parse(Console.ReadLine());
         int digitos = 0;
         while (numero != 0)
         {
            numero = numero / 10;
            digitos++;
         }

         numero = int.Parse(Console.ReadLine());
         
         Console.WriteLine(numero);
         
         
         int[] arregloDeEnteros = new int[10]; // arreglo de 10 posiciones
         arregloDeEnteros[0] = 100;
         */
         // navegacion personalizada
         // los elementos pueden modificarse

         /*
         //BUSQUEDA DE ELEMENTOS EN ARREGLO
        
         int numeroABuscar = int.Parse(Console.ReadLine());
         arregloDeEnteros = new int[] { 8, 3, 5, 1, 10,5, 16 };
         bool encontrado = false;

         // se pudo usar un foreach
         for (int i = 0; i < arregloDeEnteros.Length; i++)
         {
            if (numeroABuscar == arregloDeEnteros[i])
            {
               encontrado = true;
               break;
            }
         }
         // navegacion total por todo el conjunto de elementos
         // los elementos no pueden ser cambiados
         foreach (var item in arregloDeEnteros)
         {
            if (numeroABuscar == item)
            {
               encontrado = true;
               break;
            }
         }
         
         Console.WriteLine($"Se encontró el número {numeroABuscar}? {encontrado}");

         if (encontrado)
            Console.WriteLine($"Se encontró el número {numeroABuscar}");
         else
            Console.WriteLine("No se encontró");

         */

         //MOSTRAR CUANTOS ELEMENTOS SE ENCONTRARON EN EL ARREGLO

         int numeroABuscar = int.Parse(Console.ReadLine());
         int [] arregloDeEnteros = new int[] { 8, 3, 5, 1, 10, 5, 16 };
         int contadorDeEncontrados=0;
         /*
         foreach (int elemento in arregloDeEnteros)
         {
            if (elemento == numeroABuscar)
            {
               contadorDeEncontrados++;
            }
         }
         Console.WriteLine($"Se encontraron {contadorDeEncontrados} elementos");

         //MOSTRAR LA POSICION DONDE SE ENCONTRARON LOS ELEMENTOS


         for (int i = 0; i < arregloDeEnteros.Length; i++)
         {
            if (arregloDeEnteros[i] == numeroABuscar)
            {
               Console.WriteLine($"Se encontró en la posicion {i}");
            }
         }
         */
         // Propiedad de arreglo
         // arregloDeEnteros.Length -> cantidad de elementos de un arreglo

         // Funcion de arreglo
         // arregloDeEnteros.GetLength() -> tamaño de una dimension de un arreglo

         // CREAR UN ARREGLO CON LAS POSICIONES DONDE SE ENCONTRARON LOS ELEMENTOS
         // enteros que permiten nulls
         // PRIMERA FORMA DE RESOLVER EL PROBLEMA
         /*
         int? enteroNulo = null;
         int?[] arregloDeEncontrados = new int?[arregloDeEnteros.GetLength(0)];
         contadorDeEncontrados = 0;

         for (int i = 0; i < arregloDeEncontrados.GetLength(0); i++)
         {
            if (arregloDeEnteros[i]== numeroABuscar)
            {
               arregloDeEncontrados[contadorDeEncontrados] = i;
               contadorDeEncontrados++;
            }
         }
         foreach (var encontrado in arregloDeEncontrados)
         {
               Console.Write(encontrado + "  ");            
         }
         */
         // SEGUNDA FORMA

         
         contadorDeEncontrados = 0;

         for (int i = 0; i < arregloDeEnteros.GetLength(0); i++)
         {
            if (arregloDeEnteros[i] == numeroABuscar)
            {
               contadorDeEncontrados++;
            }
         }
         
         int[] arregloDeEncontrados = new int[contadorDeEncontrados];
         contadorDeEncontrados = 0;

         for (int i = 0; i < arregloDeEnteros.GetLength(0); i++)
         {
            if (arregloDeEnteros[i] == numeroABuscar)
            {
               arregloDeEncontrados[contadorDeEncontrados] = i;
               contadorDeEncontrados++;
            }
         }

         foreach (var encontrado in arregloDeEncontrados)
         {
            Console.Write(encontrado + "  ");
         }


      }
   }
}
