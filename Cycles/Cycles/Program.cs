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
                
            #region Task12
            //12.User gives 2 numbers. Find out if there are similar digits in those numbers.
            //Console.WriteLine("Please enter number a");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter number b");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int temp1 = a;
            //int temp2 = b;
            //while (temp1 > 0)
            //{
            //    int digitOfA = temp1 % 10;
            //    temp1 = (temp1 - digitOfA) / 10;

            //    while (temp2> 0)
            //    {
            //        int digitOfB = temp2 % 10;
            //        temp2 = (temp2 - digitOfB) / 10;
            //        if (digitOfA==digitOfB)
            //        {
            //            Console.WriteLine(digitOfB);
            //        }
            //    }
            //    temp2 = b;
            //}

            #endregion

            #region Task13
            //13.User gives a number n. Calculate:
            //Console.WriteLine("Please enter number n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <=n; i++)
            //{
            //    sum = sum+(1 + (1 / i * i));
            //}
            //Console.WriteLine($"Sum={sum}");
            #endregion

            #region Task14
            //14.User gives х, and positive n. Calculate:
            //1)
            //Console.WriteLine("Please enter number n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter number x");
            //int x = Convert.ToInt32(Console.ReadLine());
            //float sum = 0;
            //float denumerator = 1;
            //for (int i = 0; i <= n; i++)
            //{
            //    denumerator *= (x + i);
            //    sum = sum + (1 / (denumerator));
            //}
            //Console.WriteLine($"Sum={sum}");


            //2)
            //Console.WriteLine("Please enter number n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter number x");
            //int x = Convert.ToInt32(Console.ReadLine());
            //double sum =0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum+=(Math.Pow(x,i)/ Factorial(i));
            //}
            //Console.WriteLine($"Sum={sum}");
            

            //static int Factorial(int n) {
            //    int fact=1;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        fact = fact * i;
            //    }
            //    return fact;
            //}
           
            #endregion
                
                #region Task15
            //User gives positive n. Calculate:
            //1)
            //Console.WriteLine("Please enter positive number n:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double product = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    product *= (2 + (1.0 / Factorial(i)));

            //}

            //Console.WriteLine(product);



            //2)
            //Console.WriteLine("Please enter positive number n:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum += ((1 + i) / Factorial(i));

            //}

            //Console.WriteLine(sum);

            //static int Factorial(int n)
            //{
            //    int fact = 1;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        fact = fact * i;
            //    }
            //    return fact;
            //}



            #endregion

            #region Task16
            //Calculate the approximate value of an infinite sum. After equls sign you see it’s exact value for you to compare with your result.:
            //Console.WriteLine("Input number d:");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input number x:");
            //int x = Convert.ToInt32(Console.ReadLine());

            //static void checkInaccuracy(int n)
            //{
            //    double result = Math.Pow(Math.PI, 2) / 6;
            //    double sum = 0;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        sum += 1.0 / (i * i);
            //    }

            //    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
            //}
            //checkInaccuracy(n);

            //static void checkInaccuracy(int n)
            //{
            //    double result = 3.0 / 4;
            //    double sum = 0;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        sum += 1.0 / (i * (i+2));
            //    }

            //    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
            //}
            //checkInaccuracy(n);

            //static void checkInaccuracy(int d,int x)
            //{
            //    double result = Math.Pow(Math.E, x) ;
            //    int factorial = 1;
            //    double sum = 1;
            //    for (int i = 1; i <= d; i++)
            //    {
            //        factorial *= i;
            //        sum += Math.Pow(x,i) / factorial;
            //    }   

            //    Console.WriteLine($"Inaccuracy in this calculation is {result - sum}");
            //}
            //checkInaccuracy(d,x);
            #endregion

            #region Task17
            //17.Find out all 2-digits numbers, whose digit’s sum doesn’t change after multiplying this number by 2,3,4,5,6,7,8,9.
            //for (int i = 10; i <= 99; i++)
            //{
            //    for (int j = 2; j <= 9; j++)
            //    {
            //        if (SumOfDigits(i * j) == SumOfDigits(i))
            //        {
            //            Console.WriteLine($"{i}---{j}");
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}


            //static int SumOfDigits(int n)
            //{
            //    int sum = 0;
            //    int temp = n;
            //    int digit = 0;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;
            //        sum += digit;
            //        temp = (temp - digit) / 10;
            //    }
            //    return sum;
            //}

            #endregion

            #region Task18
            //18.Find out every 3-digit number that can be represented as sum of all its digit’s factorials.
            //static int Factorial(int n)
            //{
            //    int fact = 1;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        fact = fact * i;
            //    }
            //    return fact;
            //}

            //int sum = 0;
            //for (int i = 100; i <= 999; i++)
            //{
            //    int temp = i;
            //    while (temp > 0)
            //    {
            //        int currentDigit = temp % 10;
            //        int factorialDigit = Factorial(currentDigit);
            //        sum += factorialDigit;
            //        temp = (temp - currentDigit) / 10;
            //    }
            //    if (i == sum)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    sum = 0;
            //}
            #endregion

            #region Task19
            //19.Is it possible to represent given number as sum of two positive numbers powered to 2? 
            //Console.WriteLine("Please enter the number n:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //static void checkSquare(int n)
            //{
            //    for (int i = 1; i * i < n; i++)
            //    {
            //        for (int j = i; j * j < n; j++)
            //        {
            //            if ((i * i) + (j * j) == n)
            //            {
            //                Console.WriteLine($"It is possible to represent given number as sum of {i} and {j} powered to 2");
            //            }
            //        }
            //    }
            //}
            //checkSquare(n);
            #endregion

            #region Task20
            //20.Find out is given number perfect? I.e. number is equal to sum of all it’s positive divisors excepting the number by it’s own.

            //Console.Write("Please enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for(int i=1; i < number; i++)
            //{
            //    if(number % i == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //if(sum == number)
            //{
            //    Console.WriteLine("Perfect number");
            //}
            //else
            //{
            //    Console.WriteLine("Not perfect number");
            //}
            #endregion

            #region Task 21
            //21.User gives one positive number k. Find out k-th digit of series: 1234567891011121314… which have every positive numbers one by one.
            //static void GetDigit(int k)
            //{
            //    string numbers = "";
            //    for (int i = 1; i <= k; i++)
            //    {
            //        numbers += i;
            //    }
            //    Console.WriteLine(numbers[k-1]);
            //}
            //GetDigit(10);
            #endregion

            #region Task 22
            //22.User gives one positive number k. Find out k-th digit of series: 149162536… which have every positive numbers one by one powered by 2.
            //static void GetDigit(int k)
            //{
            //    string nums = "";
            //    for (int i = 1; i <= k; i++)
            //    {
            //        nums += i * i;
            //    }
            //    Console.WriteLine(nums[k-1]);
            //}
            //GetDigit(5);
            #endregion

            #region Task 23
            //23.User gives one positive number k. Find out k-th digit of Fibonacci’s series: 112358132134…

            //static void GetDigit(int k)
            //{
            //    string nums = "";
            //    int num1 = 1;
            //    int num2 = 1;
            //    nums += num1;
            //    nums += num2;

            //int[] fibonacciNums = new int[k];
            //fibonacciNums[0] = num1;
            //fibonacciNums[1] = num2;
            //for (int i = 2; i < fibonacciNums.Length; i++)
            //{
            //    fibonacciNums[i] = num1 + num2;
            //    num1 = fibonacciNums[i - 1];
            //    num2 = fibonacciNums[i];
            //    nums += fibonacciNums[i];

            //}
            //Console.WriteLine(nums[k - 1]);
            //}
            //GetDigit(7);
        #endregion
        }
    }
}

