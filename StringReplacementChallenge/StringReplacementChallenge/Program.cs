using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringReplacementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimaryChallenge();

            BonusChallenge();

            Console.ReadLine();
        }

        private static void PrimaryChallenge()
        {
            // Primary Challenge
            List<string> lines = File.ReadAllLines(@"C:\temp\primary.txt").ToList();

            Console.Write("Please give me the text to replace: ");
            string toReplace = Console.ReadLine();

            Console.Write("Please give me the replacement text: ");
            string replacementText = Console.ReadLine();

            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].Replace(toReplace, replacementText);
            }

            File.WriteAllLines(@"C:\temp\primary.txt", lines);

            Console.WriteLine("The text file has been updated.");
        }

        private static void BonusChallenge()
        {
            string bonusText = File.ReadAllText(@"C:\temp\bonus.txt");
            Dictionary<string, string> replacements = new Dictionary<string, string>();

            var results = Regex.Matches(bonusText, @"{[^{}]+}")
                .Cast<Match>()
                .Select(x => x.Value.Substring(1, x.Value.Length - 2))
                .ToHashSet();

            foreach (var result in results)
            {
                Console.Write($"Plese give me the value for { result }: ");
                replacements.Add(result, Console.ReadLine());
            }

            foreach(var item in replacements)
            {
                bonusText = bonusText.Replace("{"+item.Key+"}", item.Value);
            }

            File.WriteAllText(@"C:\temp\bonus.txt", bonusText);

            Console.WriteLine("The text file has been updated.");
        }
    }
}
