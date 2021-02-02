using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
// using ConsoleTables;

namespace ApiClient
{
  public class People
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }
        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; }
        [JsonPropertyName("skin_color")]
        public string SkinColor { get; set; }
        [JsonPropertyName("eye_color")]
        public string EyeColor { get; set; }

        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }


    }
    public class PeopleResultsContainer
    {
        public List<People> results { get; set; }

    }
  class Program
  {
    static async Task Main(string[] args)
    {
            var client = new HttpClient();
            var responseAsStream = await client.GetStreamAsync($"https://swapi.dev/api/people/");
            var starWarsPeople = await JsonSerializer.DeserializeAsync<PeopleResultsContainer>(responseAsStream);

            // var table = new ConsoleTable("Name", "Height", "Birth year");

            foreach (var person in starWarsPeople.results)
            {
              Console.WriteLine($"{person.Name}");
              
                // table.AddRow(person.Name, person.Height, person.BirthYear);
            }


            // table.Write();
    }
  }
}
