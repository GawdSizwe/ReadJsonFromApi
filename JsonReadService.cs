using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ReadJsonFromApi
{
    internal class JsonReadService
    {
        public static JObject ReadJsonFile(string jsonFileIn)
        {

            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(jsonFileIn));

            return jsonFile;

        }

    }
}