using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------- Main Challenge ------
            List<string> list1 = new List<string>
            {
                "Foo",
                "Fee",
                "Fough"
            };

            List<string> list2 = new List<string>
            {
                "Fo",
                "Fgh"
            };

            var result = MixLists(list1, list2);

            result.ForEach(x => Console.WriteLine(x));

            // ------ Bonus Challenge -------
            Person p = new Person { Title = "Hey There", Name = "Ben Thornhill" };
            Address a = new Address { Title = "Mousy", City = "Cleveland" };

            var longerResult = DetermineLongerTitle(p, a);

            Console.WriteLine(longerResult.Title);

            Console.ReadLine();
        }

        private static List<T> MixLists<T>(List<T> list1, List<T> list2) where T : class
        {
            List<T> output = new List<T>();
            List<T> biggerList;
            List<T> smallerList;

            if(list1.Count > list2.Count)
            {
                biggerList = list1;
                smallerList = list2;
            }
            else
            {
                biggerList = list2;
                smallerList = list1;
            }

            int smallerCount = smallerList.Count;

            for (int i = 0; i < biggerList.Count; i++)
            {
                output.Add(biggerList[i]);

                if(i < smallerCount)
                {
                    output.Add(smallerList[i]);
                }
            }

            return output;
        }

        private static IHaveTitle DetermineLongerTitle<T, U>(T item1, U item2) where T : IHaveTitle
                                                                               where U : IHaveTitle
        {
            if(item1.Title.Length > item2.Title.Length)
            {
                return item1;
            }
            else
            {
                return item2;
            }
        }
    }
}
