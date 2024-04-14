using Newtonsoft.Json.Linq;

namespace frontend.Utilities
{
    public class JsonReader
    {
        public dynamic ExtractDataFromJson()
        {
            string configPath = "../../../Utilities/config.json"; // Replace with the actual path
            string configJson = File.ReadAllText(configPath);
            return JObject.Parse(configJson);
        }
    }
}
