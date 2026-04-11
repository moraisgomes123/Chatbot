using System.Text.Json;
using CybersecurityChatbot.Models;

namespace CybersecurityChatbot.Services
{
    // This service is responsible for loading chatbot responses from a JSON file
    public class JsonResponseLoader
    {
        // Stores the file path to the JSON file
        private readonly string _path;

        // Constructor that accepts the path of the JSON file
        public JsonResponseLoader(string path)
        {
            _path = path;
        }

        // Loads and deserializes responses from the JSON file
        public List<Response> LoadResponses()
        {
            // Check if the file exists at the specified path
            if (!File.Exists(_path))
                // If not, return an empty list to avoid errors
                return new List<Response>();

            // Read the entire JSON file as a string
            string json = File.ReadAllText(_path);

            // Deserialize the JSON string into a List<Response> object
            // If deserialization fails (returns null), return an empty list instead
            return JsonSerializer.Deserialize<List<Response>>(json)
                   ?? new List<Response>();
        }
    }
}
