using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // Description: This uses the Star Wars API to request data and uses Web API
    class Program
    {
        private static HttpClient apiClient;
        private static List<PersonModel> peopleCache = new List<PersonModel>();

        static async Task Main(string[] args)
        {
            InitializeClient();
            string lookUpAnother = "";

            do
            {
                Console.Write("What ID would you like to use to retrieve a Star Wars character: ");
                string idText = Console.ReadLine();

                try
                {
                    PersonModel person = await GetStarWarsCharacter(idText);
                    Console.WriteLine($"{ person.FullName } is a { person.Gender }");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: { ex.Message }");
                }

                Console.Write("Do you want to look up another character (yes/no): ");
                lookUpAnother = Console.ReadLine();

                Console.Clear();
            } while (lookUpAnother.ToLower() == "yes");

            Console.ReadLine();
        }

        private static async Task<PersonModel> GetStarWarsCharacter(string id)
        {
            string uri = $"https://swapi.co/api/people/{ id }/";

            PersonModel cached = peopleCache.Where(x => x.Id == id).FirstOrDefault();

            if(cached != null)
            {
                return cached;
            }

            using(HttpResponseMessage response = await apiClient.GetAsync(uri))
            {
                if (response.IsSuccessStatusCode)
                {
                    PersonModel output = await response.Content.ReadAsAsync<PersonModel>();
                    output.Id = id;

                    // Add it to the cache
                    peopleCache.Add(output);

                    return output; 
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        private static void InitializeClient()
        {
            apiClient = new HttpClient();
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
