using CybersecurityChatbot.Chatbot;
using CybersecurityChatbot.Services;

class Program
{
    static void Main(string[] args)
    {
        // Create a loader to read chatbot responses from a JSON file
        var loader = new JsonResponseLoader("Data/responses.json");

        // Load the responses into memory (e.g., intents, replies, etc.)
        var responses = loader.LoadResponses();

        // Initialize the response service with the loaded data
        var service = new ResponseService(responses);

        // Create the chatbot engine and inject the response service
        var chatbot = new ChatbotEngine(service);

        // Start the chatbot (likely begins a console interaction loop)
        chatbot.Start();
    }
}
