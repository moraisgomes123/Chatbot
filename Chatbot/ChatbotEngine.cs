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
            _service = service ?? throw new ArgumentNullException(nameof(service));
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

                // Prevent null input
                string input = Console.ReadLine() ?? "";

                // Validate safely
                if (string.IsNullOrWhiteSpace(input) || !InputValidator.IsValid(input))
                {
                    UIFormatter.PrintBot("Invalid input.");
                    continue;
                }

                // Safe exit check
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                // Store context safely
                _context.LastTopic = input;

                // Ensure response is never null
                string response = _service.GetResponse(input) ?? "Sorry, I don't understand.";
                UIFormatter.PrintBot(response);
            }
        }
    }
}
