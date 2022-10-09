using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.Find out minimal value in array.

            //static int MinValueOfArray(int[] arr)
            //{
            //    int min = arr[0];
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i]<min)
            //        {
            //            min = arr[i];
            //        }

            //    }
            //    return min;

            //}

            //int [] arr1 = { 100, 5, 71, 99, 7 };
            //Console.WriteLine(MinValueOfArray(arr1));

            #endregion

            #region Task2
            //2.Find out maximal value in array.

            //static int MaxValueOfArray(int[] arr)
            //{
            //    int max = arr[0];
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //        {
            //            max = arr[i];
            //        }

            //    }
            //    return max;

            //}

            //int[] arr1 = { 100, 5, 71, 99, 7 };
            //Console.WriteLine(MaxValueOfArray(arr1));

            #endregion

            #region Task3
            //3.Find out index of minimal value in array.
            //static int IndexOfMinValueOfArray(int[] arr)
            //{
            //    int min = arr[0];
            //    int minIndex = 0;
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] < min)
            //        {
            //            min = arr[i];
            //            minIndex = i;
            //        }

            //    }
            //    return minIndex;

            //}

            //int[] arr1 = { 100, 5, 71, 99, 7 ,3};
            //Console.WriteLine(IndexOfMinValueOfArray(arr1));

            #endregion

            #region Task4
            //4.Find out index of maximal value in array.
            //static int IndexOfMaxValueOfArray(int[] arr)
            //{
            //    int max = arr[0];
            //    int maxIndex = 0;
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //        {
            //            max = arr[i];
            //            maxIndex = i;
            //        }

            //    }
            //    return maxIndex;

            //}

            //int[] arr1 = { 100, 5, 71, 99, 7, 3 };
            //Console.WriteLine(IndexOfMaxValueOfArray(arr1));

            #endregion

            #region Task5
            //5.Calculate sum of all elements with odd indexes.
            //static int SumOffElementsWithOddIndexes(int[] arr)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (i%2!=0)
            //        {
            //            sum += arr[i];

            //        }
            //    }
            //    return sum;
            //}

            //int[] arr1 = { 100, 5, 71, 99, 7, 3 };
            //Console.WriteLine(SumOffElementsWithOddIndexes(arr1));

            #endregion

            #region Task6
            //6.Reverse an array (f.e. 1 2 3 4 5-> 5 4 3 2 1)

            //static void ReverseArray(int[] nums)
            //{
            //    for (int i = 0; i < nums.Length / 2; i++)
            //    {
            //        int temp = nums[i];
            //        nums[i] = nums[nums.Length - i - 1];
            //        nums[nums.Length - i - 1] = temp;
            //    }
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        Console.WriteLine(nums[j]);
            //    }
            //}
            //int[] arr1 = { 100, 5, 71, 99, 7, 3 };
            //ReverseArray(arr1);
            #endregion

            #region Task7
            //7.Calculate amount of all elements with odd values.

            //static int AmountOfOddValues(int[] arr)
            //{
            //    int counter = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i]%2!=0)
            //        {
            //            counter++;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    return counter;
            //}
            //int[] arr1 = { 100, 5, 71, 99, 7, 3 };
            //Console.WriteLine(AmountOfOddValues(arr1));

            #endregion

            #region Task8
            //8.Change first and second half of array(f.e. 1 2 3 4 -> 3 4 1 2, or 1 2 3 4 5-> 4 5 3 1 2).

            //static void ChangeArray(int[] arr1)
            //{
            //    int HalfArrLengt = arr1.Length / 2;
            //    if (arr1.Length % 2 == 1)
            //    {
            //        for (int i = 0; i < HalfArrLengt; i++)
            //        {
            //            int temp = arr1[i];
            //            arr1[i] = arr1[HalfArrLengt + i + 1];
            //            arr1[HalfArrLengt + i + 1] = temp;
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 0; i < HalfArrLengt; i++)
            //        {
            //            int temp = arr1[i];
            //            arr1[i] = arr1[HalfArrLengt + i];
            //            arr1[HalfArrLengt + i] = temp;
            //        }
            //    }

            //    for(int j = 0; j < arr1.Length; j++)
            //    {
            //        Console.WriteLine(arr1[j]);
            //    }
            //}

            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //ChangeArray(nums);

            #endregion

            #region Task9
            //9.Sort array with one of those methods: bubble, select or insert.
            //static int[] BubbleSort(int[] arr)
            //{
            //    for (int k = 0; k < arr.Length-1; k++)
            //    {
            //        bool flag=false;
            //        for (int i = 1; i < arr.Length-k; i++)
            //        {
            //            if (arr[i] > arr[i-1])
            //            {
            //                (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
            //                flag = true;
            //            }
            //        }
            //        if (!flag) return arr;
                   
            //    }
            //    return arr;
            //}
            #endregion

            #region SelectionSort

            //static int[] SelectionSort(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length-1; i++)
            //    {
            //        int minIndex = i;
            //        for (int k = i; k < arr.Length; k++)
            //        {
            //            if (arr[k] < arr[minIndex])
            //            {
            //                minIndex = k;
            //            }
            //        }
            //        (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            //    }
            //    return arr;
            //}

            #endregion


        }
    }
}