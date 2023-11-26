using System;
using System.Diagnostics;

namespace Day8
{
    internal class Program
    {
        static int val = 0;


        static string sum( int[] num, int target)
        {
            for (int i = 0; i < num.Length; i++)
            
               for (int j = 1; j < num.Length; j++)
                    if (num[i] + num[j] == target) return $"{i + 1} {j + 1}";
            
            return "-1";
        }

        static string sum1(int[] num, int target)
        {
            Array.Sort(num);
            int start = 0;
            int end = num.Length - 1;
            while (start < end) {
                if (num[start] + num[end] == target) return $"{num[start]} {num[end]}";
                else if (num[start] + num[end] < target) start++;
                else end--;
            }

            return "-1";
        }

        static void multy(int n = 1)
        {
            for (int j = 1; j < n; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine("-----------------------------------");
            }
        }

        static void gitUserValues()
        {
            int arrSize, target;


            string s = Console.ReadLine();
            string[] valeGiving = s.Split(" ");


            arrSize = int.Parse(valeGiving[0]);
            target = int.Parse(valeGiving[1]);

            int[] values = new int[arrSize];
            s = Console.ReadLine();
            string[] valuesSplit = s.Split(" ");



            for (int i = 0; i < arrSize; i++) values[i] = int.Parse(valuesSplit[i]);


            sum(values, target);
            sum1(values, target);
        }

        static void Main(string[] args)
        {
            //  int s = Console.Read();

            gitUserValues();
            multy(4);



            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        Console.Write(x);

                        Thread.Sleep(1);
                    }
                    Console.WriteLine();
                }

                       


            stopwatch.Stop();

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);


            
           



        }
    }
}