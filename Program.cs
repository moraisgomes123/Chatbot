using CybersecurityChatbot.Chatbot;
using CybersecurityChatbot.Services;

class Program
{
    static void Main(string[] args)
    {
        var loader = new JsonResponseLoader("Data/responses.json");
        var responses = loader.LoadResponses();

        var service = new ResponseService(responses);
        var chatbot = new ChatbotEngine(service);

        chatbot.Start();
    }
}