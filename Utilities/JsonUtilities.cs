//UnitConverter.cs
using System.Text.Json;

namespace Synaptica.Utilities;

public class JsonUtilities(IWebHostEnvironment webHostEnvironment, ILogger<JsonUtilities> logger) {
         //T is param for your generics
         // IList<Food> goes inside here
         // GetFromJson<int> GetFromJson<string>
    public T? GetFromJson<T>(string path)
    {
        var fullPath = webHostEnvironment.WebRootPath + path;
        try
        {
            // grabs string content from json
            string jsonStr = File.ReadAllText(fullPath);
            // turns string content into a JsonData object
            var deserialized = JsonSerializer.Deserialize<JsonWrapper<T>>(jsonStr);
            if (deserialized == null) {
                return default;
            }

            return deserialized.Value;
        }
        catch (FileNotFoundException)
        {
            // do nothing
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to deserialize JSON at path: {fullPath}", fullPath);
        }
        
        return default;
    }
                                    // foods
    public void WriteToJson(string path, object obj)
    {                                               // { "Value": []}
        var json = new JsonWrapper<object>{ Value = obj }; // Value = foods
        //Serialize (turn the object to a string) so that we can write it somewhere
        var serialized = JsonSerializer.Serialize(json);
        //Write to the Json file
        File.WriteAllText(webHostEnvironment.WebRootPath + path, serialized);
    }

    public class JsonWrapper<T>
    {
        public T? Value { get; set; }
    }
}