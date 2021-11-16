using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReadJsonFromApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = JsonReadService.ReadJsonFile(AskForJsonFile());
            getData(results);
            Console.ReadLine();
        }

        public static string AskForJsonFile()
        {
        BEGIN:
            Console.WriteLine("Any any key to start the program.");
            Console.ReadKey();
            if (File.Exists("endpoints.json"))
            {
                return "endpoints.json";
            }
            else
            {
                Console.Write("\nError: File doesn't exist!");
                goto BEGIN;
            }
        }

        public static void getData(dynamic jsonFile)
        {
            foreach (var item in jsonFile["services"])
            {
                foreach (var itemDetails in item["endpoints"])
                {
                    foreach (var itemDetailRegex in itemDetails["response"])

                    {
                        Console.WriteLine(item["baseURL"]+ itemDetails["resource"]);

                        var client = new RestClient($"{item["baseURL"]}");
                        var request = new RestRequest($"{itemDetails["resource"]}");
                        var response = client.Execute(request);

                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            string rawResponse = response.Content;
                            ResponseModel result = JsonConvert.DeserializeObject<ResponseModel>(rawResponse);

                            if (result.name == $"{itemDetailRegex["regex"]}")
                            {
                                Console.WriteLine("Initiate call");
                                continue;
                            }
                            if (result.title == $"{itemDetailRegex["regex"]}")
                            {
                                Console.WriteLine("Initiate call");
                                continue;
                            }
                            if (result.director == $"{itemDetailRegex["regex"]}")
                            {
                                Console.WriteLine("Initiate call");
                                continue;
                            }
                            if (result.height == $"{itemDetailRegex["regex"]}")
                            {
                                Console.WriteLine("Initiate call");
                                continue;
                            }
                            if (result.director == $"{itemDetailRegex["regex"]}")
                            {
                                Console.WriteLine("Initiate call");
                                continue;
                            }
                            if (result.translation == $"{itemDetailRegex["regex"]}")
                            {
                                Console.WriteLine("Initiate call");
                                continue;
                            }
                            else
                                Console.WriteLine("Skip call");

                        }
                        else
                            Console.WriteLine("Skip call");
                    }

                }

                Console.WriteLine("----------------------------------------------------------------------------------------");
            }


        }
    }
}
