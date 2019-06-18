using System;
using System.Linq;

namespace LINQChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";

            // -- This is the base challenge
            //var letters = from x in input
            //              orderby x.ToString()
            //              select x;

            //foreach (var letter in letters)
            //{
            //    Console.WriteLine(letter);
            //}

            var letters = from x in input
                          group x by x.ToString().ToLower() into y // This makes it so that letters are counted whether they are capitalized or not
                          orderby y.Count() descending, y.Key.ToString()
                          select (new { Letter = y.Key, Count = y.Count() }); // Uses anonymous object - You could use a LetterModel instead
             
            foreach (var letter in letters)
            {
                Console.WriteLine($"Letter: {letter.Letter}, Count: {letter.Count}");
            }

            Console.ReadLine();
        }

        public class LetterModel
        {
            public string Letter { get; set; }
            public int Count { get; set; }
        }
    }
}
