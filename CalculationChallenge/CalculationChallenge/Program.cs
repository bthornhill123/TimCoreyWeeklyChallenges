using System;

namespace CalculationChallenge
{

    // The commented out code in Temperature.cs is optimized for reads. The uncommented code is optimized for writes becuase no logic is done on the insert method.

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            ITemperature temperature = new Temperature();
            string[] words = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            for (int i = 0; i < 100; i++)
            {
                temperature.Insert(rand.Next(1, 101));
            }

            for (int i = 0; i < 100; i++)
            {
                temperature.Insert(words[rand.Next(0, 10)]);
            }

            Console.WriteLine($"Min temp: { temperature.MinimumTemperature }");
            Console.WriteLine($"Max temp: { temperature.MaximumTemperature }");
            Console.WriteLine($"Avg temp: { temperature.AverageTemperature }");

            Console.ReadLine();
        }
    }
}
