using System;
using System.Text;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.User gives 2 numbers a, b. Output a to the power of b(not using Math.pow).
            //Console.WriteLine("Please enter number a");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter number b");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < b; i++)
            //{
            //    result = result * a;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Task2
            // 2.User gives 1 number a. Output amount of number from 1 to 1000 that have no reminder when divided by a.
            // Console.WriteLine("Please enter number a");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //        int count = 0;
            //        for (int i = 1; i < 1000; i++)
            //        {
            //            if (i % a == 0)
            //            {
            //                count += 1;
            //            }
            //        }
            #endregion

            #region Task3
            //3.User gives 1 number a. Output all positive numbers whose square will be lesser than a
            //Console.WriteLine("Please enter number a");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i * i < a; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Task4
            //4.User gives 1 number a. Output largest divisor to that number.

            //Console.WriteLine("Please enter number a");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i < a; i++)
            //{
            //    if (a % i == 0)
            //    {
            //        result = i;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //Console.WriteLine(result);
            #endregion

            #region Task5
            //5.User gives 2 numbers a, b. Output sum of all numbers from range a to b that have no reminder when divided by 7. (there can be situation when b lesser than a)

            //Console.WriteLine("Please enter number a");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter number b");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //if (a < b)
            //{
            //    for (int i = a; i <= b; i++)
            //    {
            //        if (i % 7 == 0)
            //        {
            //            sum += i;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}
            //else if (b < a)
            //{
            //    for (int i = b; i <= a; i++)
            //    {
            //        if (i % 7 == 0)
            //        {
            //            sum += i;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Task6
            //6.User gives 1 number a. Output a-th number of Fibonacci’s series. (In Fibonacci series every next number is sum of previous two. F.e. : 1 1 2 3 5 8 13 21 …)

            //Console.WriteLine("Please enter number a ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int num1 = 1;
            //int num2 = 1;
            //int next;
            //for (int i = 2; i < a; i++)
            //{
            //    next = num1 + num2;
            //    num1 = num2;
            //    num2 = next;
            //}
            //Console.WriteLine(num2);
            #endregion

            #region Task7
            //7.User gives 2 numbers. Find out their greatest common divisor using Euclid’s algorithm.
            //Console.WriteLine("Please enter first number:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter second number:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int gcd = 1;
            //if (a < b)
            //{
            //    for (int i = 2; i <= a; i++)
            //    {
            //        if (a % i == 0 && b % i == 0)
            //        {
            //            gcd = i;
            //        }
            //        else
            //        {
            //            continue;
            //        }

            //    }
            //}
            //else if (b < a)
            //{
            //    for (int i = 2; i <= b; i++)
            //    {
            //        if (a % i == 0 && b % i == 0)
            //        {
            //            gcd = i;
            //        }
            //        else
            //        {
            //            continue;
            //        }

            //    }
            //}
            //else if (a == b)
            //{
            //    gcd = a;
            //}
            //Console.WriteLine($"Great Common Divisor:{gcd} ");
            #endregion

            #region  Task 8
            //8.User gives a positive number that is power of another number to 3. Find out that number using half division method. (F.e. : 8->2 )
            //Console.Write("Enter positive number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for(int i=1; i < num; i++)
            //{
            //    if(i*i*i == num)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}
            #endregion

            #region Task 9
            //9.User gives 1 number. Find out amount of odd digits in this number.
            //Console.Write("Enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int temp = num;
            //int count = 0;
            //while(temp > 0)
            //{
            //    int digit = temp % 10;
            //    if(digit % 2 != 0)
            //    {
            //        count++;
            //    }
            //    temp = (temp - temp % 10) / 10;
            //}
            //Console.Write(count);
            #endregion

            #region Task 10
            //10.User gives 1 number. Find out mirrored number to that one. F.e. : 1234 -> 4321.
            //Console.Write("Enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int temp = num;
            //int mirroredNum = 0;
            //while(temp > 0)
            //{
            //    int digit = temp % 10;
            //    temp = (temp - digit) / 10;
            //    mirroredNum = (mirroredNum * 10) + digit;
            //}
            //Console.Write(mirroredNum);
            #endregion

            #region Task 11
            //11.User gives 1 number a. Find out every number in range 1 to a whose sum of even digits bigger than odd.
            //Console.Write("Enter number a: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int evenSum = 0;
            //int oddSum = 0;
            //for (int i = 1; i < num; i++)
            //{
            //    int temp = i;
            //    while (temp > 0)
            //    {
            //        int digit = temp % 10;
            //        if (digit % 2 == 0)
            //        {
            //            evenSum += digit;
            //        }
            //        else
            //        {
            //            oddSum += digit;
            //        }
            //        temp = (temp - digit) / 10;
            //    }
            //    if (evenSum > oddSum)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    evenSum = 0;
                //oddSum = 0;
            //}
            #endregion
        }
    }
}

