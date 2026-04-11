namespace CybersecurityChatbot.Chatbot
{
    // Handles formatting and coloring of console output.  
    public static class UIFormatter
    {
        // Displays the user prompt using their name.
        public static void PrintUserPrompt(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{userName}: ");
            Console.ResetColor();
        }
        // Displays the bot response in a styled format.
        public static void PrintBot(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bot: " + message);
            Console.ResetColor();
        }
    }
}
