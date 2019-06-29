using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static string[] tests = new string[]
        {
            @"The test of the 
            best way to handle

multiple lines,   extra spaces and more.",
            @"Using the starter app, create code that will 
loop through the strings and identify the total 
character count, the number of characters
excluding whitespace (including line returns), and the
number of words in the string. Finally, list each word, ensuring it
is a valid word."
        };

        /* 
            First string (tests[0]) Values:
            Total Words: 14
            Total Characters: 89
            Character count (minus line returns and spaces): 60
            Most used word: the (2 times)
            Most used character: e (10 times)

            Second string (tests[1]) Values:
            Total Words: 45
            Total Characters: 276
            Character count (minus line returns and spaces): 230
            Most used word: the (6 times)
            Most used character: t (24 times)
        */

        static void Main(string[] args)
        {
            foreach (string test in tests)
            {
                string filteredTest = test.Replace(Environment.NewLine, " ");

                // Total character count
                GetTotalCharacters(filteredTest);

                // Number of non-whitespace/non-line return characters
                GetNonWhitespaceCharacters(filteredTest);

                // Number of words in a string
                List<string> words = GetWordsFromString(filteredTest);

                // Unique words list
                // Most used word
                FindUniqueWords(words);

                // Unique character list (just a-z)
                // Most used character 
                FindUniqueCharacters(filteredTest);

                // List of words
                Console.WriteLine();
                Console.WriteLine($"****** All words ******");
                words.ForEach(word => Console.WriteLine(word));
                Console.WriteLine($"****** All words ******");

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void FindUniqueCharacters(string filteredTest)
        {
            Regex alphaCheck = new Regex("[^a-zA-Z]");
            string cleanedTest = alphaCheck.Replace(filteredTest, "");

            var results = from c in cleanedTest.ToLower()
                          group c by c into g
                          orderby g.Count() descending
                          select new
                          {
                              Total = g.Count(),
                              Letter = g.Key.ToString()
                          };

            Console.WriteLine($"Most used letters: { results.FirstOrDefault()?.Letter } ({ results.FirstOrDefault()?.Total } times)");
            Console.WriteLine();

            Console.WriteLine($"****** Unique Letters ******");
            results.ToList().ForEach(letter => Console.WriteLine(letter.Letter));
            Console.WriteLine($"****** Unique Letters ******");
        }

        private static void FindUniqueWords(List<string> words)
        {
            var results = from word in words
                          group word by word.ToLower() into g
                          orderby g.Count() descending
                          select new
                          {
                              Total = g.Count(),
                              Word = g.Key
                          };

            Console.WriteLine($"Most used word: { results.FirstOrDefault()?.Word } ({ results.FirstOrDefault()?.Total } times)");
            Console.WriteLine();

            Console.WriteLine($"****** Unique words ******");
            results.ToList().ForEach(anonymousObject => Console.WriteLine(anonymousObject.Word));
            Console.WriteLine($"****** Unique words ******");
        }

        private static List<string> GetWordsFromString(string filteredTest)
        {
            List<string> output;
            Regex alphaCheck = new Regex("[^a-zA-Z ]");
            string cleanedTest = alphaCheck.Replace(filteredTest, "");

            output = cleanedTest.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            Console.WriteLine($"Total Words: { output.Count() }");

            return output;

        }

        private static void GetNonWhitespaceCharacters(string filteredTest)
        {
            Console.WriteLine($"Total Non-Whitespace Characters: { filteredTest.Where(x => x != ' ').Count() }");
        }

        private static void GetTotalCharacters(string filteredTest)
        {
            Console.WriteLine($"Total Characters: { filteredTest.Length }");
        }
    }
}
