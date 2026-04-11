using CybersecurityChatbot.Services;
using CybersecurityChatbot.Utilities;

namespace CybersecurityChatbot.Chatbot
{
    // Main engine that controls the chatbot flow and interaction with the user.
    public class ChatbotEngine
    {
        // Service responsible for generating responses
        private readonly ResponseService _service;

        // Stores conversation-related data (user name, last topic, etc.)
        private readonly ConversationContext _context = new();

        //Constructor that initializes the chatbot with a response service.
        public ChatbotEngine(ResponseService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        // Starts the chatbot interaction loop.
        public void Start()
        {
            Console.WriteLine("Initializing Cybersecurity Chatbot...\n");
            // 🔊 Play greeting audio
            new VoiceGreeting().PlayGreeting();

            // 🎨 Display ASCII banner
            AsciiArt.Show();

            Console.WriteLine("\nType 'exit' to quit.\n");

            // 👤 Ask user for their name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please enter your name: ");
            Console.ResetColor();

            string userName = Console.ReadLine() ?? "";

            // If user enters nothing, default to "User"
            if (string.IsNullOrWhiteSpace(userName))
                userName = "User";

            // Capitalize the first letter and normalize the rest
            userName = char.ToUpper(userName[0]) + userName.Substring(1).ToLower();

            // Store name in context
            _context.UserName = userName;

            // 🎉 Display welcome message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nWelcome, {userName}!");
            Console.ResetColor();

            Console.WriteLine("\nWhat do you want to know?\n");

            // 🔁 Main chatbot loop
            while (true)
            {
                // Show user prompt with their name
                UIFormatter.PrintUserPrompt(_context.UserName);

                // Read user input safely
                string input = Console.ReadLine() ?? "";

                // Validate input
                if (string.IsNullOrWhiteSpace(input) || !InputValidator.IsValid(input))
                {
                    UIFormatter.PrintBot("Invalid input.");
                    continue;
                }

                // Exit condition
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                // Store last topic entered by user
                _context.LastTopic = input;

                // Get response from service (fallback if null)
                string response = _service.GetResponse(input) ?? "Sorry, I don't understand.";

                // Display bot response
                UIFormatter.PrintBot(response);
            }
        }
    }
}
