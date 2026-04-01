namespace CybersecurityChatbot.Chatbot
{
    public static class UIFormatter
    {
        public static void PrintUserPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You: ");
            Console.ResetColor();
        }

        public static void PrintBot(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bot: " + message);
            Console.ResetColor();
        }
    }
}