using System;
using RestSharp;
using Newtonsoft.Json;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/totodile");

            request.AddParameter("uid", "ANMA0000032338");

            IRestResponse response = client.Get(request);

            //string content = response.Content;

            //System.Console.WriteLine(content);

            pokemon totodile = JsonConvert.DeserializeObject<pokemon>(response.Content);

            Console.WriteLine(totodile.weight);

            Console.ReadLine();



        }
    }
}
