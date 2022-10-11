using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.Find out minimal element.
            //static void MinElement(int[ , ] arr)
            //{
            //    int minValue = arr[0, 0];
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            if (arr[i, j] < minValue)
            //            {
            //                minValue = arr[i, j];
            //            }
            //        }
            //    }
            //    Console.WriteLine(minValue);
            //}
            //int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            //MinElement(arr);
            #endregion

            #region Task2
            //2.Find out maximal element.
            //static void MaxElement(int[,] arr)
            //{
            //    int maxValue = arr[0, 0];
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            if (arr[i, j] > maxValue)
            //            {
            //                maxValue = arr[i, j];
            //            }
            //        }
            //    }
            //    Console.WriteLine(maxValue);
            //}
            //int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            //MaxElement(arr);
            #endregion

            #region Task3
            //3.Find out index of maximal element.
            //static void MaxElementIndex(int[,] arr)
            //{
            //    int maxValue = arr[0, 0];
            //    int maxValueIndex1 = 0;
            //    int maxValueIndex2 = 0;
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            if (arr[i, j] > maxValue)
            //            {
            //                maxValue = arr[i, j];
            //                maxValueIndex1 = i;
            //                maxValueIndex2 = j;
            //            }
            //        }
            //    }
            //    Console.WriteLine($"[{maxValueIndex1},{maxValueIndex2}]");
            //}
            //int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            //MaxElementIndex(arr);
            #endregion

            #region Task4
            //3.Find out index of minimal element.
            //static void MinElementIndex(int[,] arr)
            //{
            //    int minValue = arr[0, 0];
            //    int minValueIndex1 = 0;
            //    int minValueIndex2 = 0;
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            if (arr[i, j] < minValue)
            //            {
            //                minValue = arr[i, j];
            //                minValueIndex1 = i;
            //                minValueIndex2 = j;
            //            }
            //        }
            //    }
            //    Console.WriteLine($"[{minValueIndex1},{minValueIndex2}]");
            //}
            //int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            //MinElementIndex(arr);
            #endregion
               
             #region Task5
            //5.Find out amount of elements that are bigger than every it’s neighbor.
            //static void AmountOfBiggerElementsThanNeighbors(int[,] arr)
            //{
            //    int count = 0;
            //    for (int i = 1; i < arr.GetLength(0)-1; i++)
            //    {

            //        for (int j = 1; j < arr.GetLength(1)-1; j++)
            //        {
            //            if (i==0 || j==0)
            //            {

            //            }
            //            Console.WriteLine(arr[i, j]);
            //            if (arr[i, j] > arr[i+1,j] && arr[i, j] > arr[i,j+1] && arr[i, j] > arr[i-1,j] && arr[i, j] > arr[i,j-1])
            //            {
            //                count++;
            //                //Console.WriteLine(arr[i,j]);
            //            }
            //        }
            //    }
            //    //Console.WriteLine(count);
            //}
            //int[,] arr = new int[,] {  { 1, 2 ,6},
            //                           { 3, 4 ,9},
            //                           { 5, 99 ,34},
            //                           { 7, 8 ,65},
            //                           { 9, 10,3 } };
            //AmountOfBiggerElementsThanNeighbors(arr);
            #endregion


            #region Task12
            //Console.Write("Enter your number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[,] arr = new int[n, n];
            //int printValue = 1;
            //int c1 = 0, c2 = n - 1;
            //while (printValue <= n * n)
            //{
            //    //Right Direction Move  
            //    for (int i = c1; i <= c2; i++)
            //        arr[c1, i] = printValue++;

            //    //Down Direction Move  
            //    for (int j = c1 + 1; j <= c2; j++)
            //        arr[j, c2] = printValue++;

            //    //Left Direction Move  
            //    for (int i = c2 - 1; i >= c1; i--)
            //        arr[c2, i] = printValue++;

            //    //Up Direction Move  
            //    for (int j = c2 - 1; j >= c1 + 1; j--)
            //        arr[j, c1] = printValue++;
            //    c1++;
            //    c2--;
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();
            #endregion


        
    }
    }
}

