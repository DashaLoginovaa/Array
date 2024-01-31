using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] Arr = { {1,2,3 }, {4,5,6 }, {7,8,9 }, {3,4,5 } };
            for (int i = 0; i < Arr.GetUpperBound(1) + 1; i++) 
            {
                for (int j = 0; j < Arr.GetUpperBound(0) + 1; j++) 
                {
                    Console.Write(Arr[j, i] + " ");
                }
                

                Console.WriteLine();
            }
            
                
            
            Console.ReadKey();
            */

            //отсортировать массив
            /* var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int n;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++) 
                {
                    if (arr[i] > arr[j]) 
                    {
                        n = arr[i];
                        arr[i] = arr[j];
                        arr[j] = n;


                    }
                }

            }
            foreach (int i in arr) 
            {
                Console.Write(i);
            }
            
            Console.ReadKey();
            */






            //найти сумму всех элементов

            /*var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine(sum);
            Console.ReadKey();
            */





            //количество положительных чисел в массиве

            /*
            int[] array = { 1, 6, 3, 7, 2, -9, -6, 56, -5 };
            byte kol = 0;
            foreach (int i in array)
            {
                if (i > 0) 
                {
                    kol += 1;
                }
            }
            Console.WriteLine(kol);
            Console.ReadKey();
            */


            //сумма чисел в двумерном массиве
            /*
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            int kol = 0;
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++) 
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++) 
                {
                    kol += array[i, j];
                }
              
            }
            Console.WriteLine(kol);
            Console.ReadKey();
            */


            //с помощью форыч
            /*
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            int kol = 0;
            foreach (int i in array)
            {
                kol += i;
            }
            Console.WriteLine(kol);
            Console.ReadKey();
            */




            //сортировка чисел в двумерном массиве

            /*
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int n;
            for (int i = 0; i <= arr.GetUpperBound(0) ; i++) 
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++) 
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1) ; k++)
                    {
                        if (arr[i, j] > arr[i, k]) 
                        {
                            n = arr[i, k];
                            arr[i,k] = arr[i, j];
                            arr[i,j] = n;
                           

                        }
            
                    }

                }
                

            }
            int x = arr.GetLength(0);
            int y = arr.GetLength(1);
            for (int o = 0; o < x; o++)
            {
                for (int p = 0; p < y; p++)
                {
                    Console.Write(arr[o, p]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
            */
            
           
        }
    }
}
