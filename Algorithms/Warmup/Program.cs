﻿namespace Warmup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(timeConversion("12:05:45AM"));
            Console.ReadKey();
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int total1 = 0;
            int total2 = 0;
            for (int i = 0; i < a.Count; i++)
            { 
                if (a[i] > b[i])
                    total1++;
                else if (b[i] > a[i])
                    total2++;
            }
            return new List<int> { total1, total2 };
        }
        public static long aVeryBigSum(List<long> ar)
        {
            long result = 0;
            foreach (long n in ar)
            {
                result += n;
            }
            return result;
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumPrimDiag = 0;
            int sumSecDiag = 0;
            int size = arr.Count - 1;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                        sumPrimDiag += arr[i][j];
                    if (j == size)
                    {
                        sumSecDiag += arr[i][j];
                        --size;
                    }
                }
            }
            return Math.Abs(sumSecDiag + sumPrimDiag);
        }
        public static void plusMinus(List<int> arr)
        {
            float size = arr.Count;
            int nPos = 0, nNeg = 0, nZero = 0;

            foreach (int n in arr)
            {
                if (n > 0)
                    nPos++;
                else if (n < 0)
                    nNeg++;
                else
                    nZero++;
            }
            Console.WriteLine($"{nPos / size:N6}");
            Console.WriteLine($"{nNeg / size:N6}");
            Console.WriteLine($"{nZero / size:N6}");
        }
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static void miniMaxSum(List<int> arr)
        {
            long minSum = long.MaxValue;
            long maxSum = long.MinValue;
            for (int i = 0; i < arr.Count; i++)
            {
                long Temp = 0;
                
                for (int j = 0; j < arr.Count; j++)
                {
                    if (j == i)
                        continue;
                    Temp += arr[j];
                }
                if (Temp < minSum)
                    minSum = Temp;
                if (Temp > maxSum)
                    maxSum = Temp;
            }
            Console.WriteLine($"{minSum} {maxSum}");
        }
        public static int birthdayCakeCandles(List<int> candles)
        {
            int tollest = candles.Max();
            int count = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i] == tollest)
                    count++;
            }
            return count;
        }
        public static string timeConversion(string s)
        {
            var time = s.Split(':');
            int hour = int.Parse(time[0]);
            int min = int.Parse(time[1]);
            int sec = int.Parse(time[2].Substring(0, 2));
            string amPm = time[2].Substring(2, 2);
            if (amPm == "PM" && hour != 12)
                hour += 12;
            if (amPm == "AM" && hour == 12)
                hour = 0;
            return ($"{hour:00}:{min:00}:{sec:00}");
        }
    }
}
