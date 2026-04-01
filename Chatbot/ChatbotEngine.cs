using CybersecurityChatbot.Services;
using CybersecurityChatbot.Utilities;

namespace CybersecurityChatbot.Chatbot
{
    public class ChatbotEngine
    {
        private readonly ResponseService _service;
        private readonly ConversationContext _context = new();

        public ChatbotEngine(ResponseService service)
        {
            _service = service;
        }

        public void Start()
        {
            AsciiArt.Show();

            // 🔊 PLAY AUDIO
            new VoiceGreeting().PlayGreeting();

            Console.WriteLine("\nType 'exit' to quit.\n");

            while (true)
            {
                UIFormatter.PrintUserPrompt();
                string input = Console.ReadLine();

                if (!InputValidator.IsValid(input))
                {
                    UIFormatter.PrintBot("Invalid input.");
                    continue;
                }

                if (input.ToLower() == "exit")
                    break;

                _context.LastTopic = input;

                string response = _service.GetResponse(input);
                UIFormatter.PrintBot(response);
            }
        }
    }
}