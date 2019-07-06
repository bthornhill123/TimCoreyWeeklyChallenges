﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- Without using the test harness ----
            //Stopwatch stopwatch = Stopwatch.StartNew();

            //stopwatch.Start();

            //string test = "";

            //for (int i = 0; i < 50000; i++)
            //{
            //    test += "Testing";
            //}

            //stopwatch.Stop();
            //Console.WriteLine($"Time Taken: { stopwatch.ElapsedMilliseconds } ms");


            //// StringBuilder Test
            //stopwatch = Stopwatch.StartNew();

            //stopwatch.Start();

            //StringBuilder stringBuilder = new StringBuilder();

            //for (int i = 0; i < 50000; i++)
            //{
            //    stringBuilder.Append("Testing");
            //}

            //// Convert string builder to string
            //string sbOutput = stringBuilder.ToString();

            //stopwatch.Stop();
            //Console.WriteLine($"Time Taken: { stopwatch.ElapsedMilliseconds } ms");

            //int[] iterations = new int[] { 500, 5000, 50000 };

            //CalculateSpeed(AppendTextTest, iterations, "Append Text");
            //CalculateSpeed(StringBuilderTest, iterations, "String Builder");

            int[] iterations = new int[] { 500000, 5000000 };

            CalculateSpeed(DoubleTest, iterations, "Double");
            CalculateSpeed(DecimalTest, iterations, "Decimal");

            Console.ReadLine();
        }

        public static void DoubleTest(int repetitions)
        {
            double x = 4.25;
            double y = 5.83;

            for (int i = 0; i < repetitions; i++)
            {
                x += y;
            }
        }

        public static void DecimalTest(int repetitions)
        {
            decimal x = 4.25M;
            decimal y = 5.83M;

            for (int i = 0; i < repetitions; i++)
            {
                x += y;
            }
        }

        public static void AppendTextTest(int repetitions)
        {
            string test = "";
            for (int i = 0; i < repetitions; i++)
            {
                test += "Testing";
            }
        }

        public static void StringBuilderTest(int repetitions)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < repetitions; i++)
            {
                stringBuilder.Append("Testing");
            }

            // Convert string builder to string
            string sbOutput = stringBuilder.ToString();
        }

        public static void CalculateSpeed(Action<int> methodToTest, int[] repetitions, string testName)
        {
            for (int i = 0; i < repetitions.Length; i++)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                stopwatch.Start();

                methodToTest(repetitions[i]);

                stopwatch.Stop();
                Console.WriteLine($"{ testName } { repetitions[i] } reps: { stopwatch.ElapsedMilliseconds }ms");
            }
        }
    }
}
