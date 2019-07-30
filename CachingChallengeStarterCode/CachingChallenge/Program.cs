using System;
using System.Linq;

namespace CachingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessCache db = new DataAccessCache();

            var people = db.SimulatedPersonListLookup();

            people = db.SimulatedPersonListLookup();

            people = db.SimulatedPersonListLookup();

            Console.ReadLine();
        }
    }
}
