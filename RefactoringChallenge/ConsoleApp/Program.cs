using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static HelperLibrary.DataAccess;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string actionToTake = "";
            string connectionString = GetConnectionString();

            do
            {
                Console.Write("What action do you want to take (Display, Add, or Quit): ");
                actionToTake = Console.ReadLine();

                switch (actionToTake.ToLower())
                {
                    case "display":
                        var records = GetAllUsers();

                        Console.WriteLine();
                        records.ForEach(x => Console.WriteLine(x.FullName));
                        Console.WriteLine();
                        break;
                    case "add":
                        Console.Write("What is the first name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("What is the last name: ");
                        string lastName = Console.ReadLine();

                        using (IDbConnection cnn = new SqlConnection(connectionString))
                        {
                            var p = new
                            {
                                FirstName = firstName,
                                LastName = lastName
                            };

                            cnn.Execute("dbo.spSystemUser_Create", p, commandType: CommandType.StoredProcedure);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (actionToTake.ToLower() != "quit");
        }
    }
}
