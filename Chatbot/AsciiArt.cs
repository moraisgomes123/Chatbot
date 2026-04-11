namespace CybersecurityChatbot.Chatbot
{
    // Displays a styled ASCII banner for the chatbot.
    public static class AsciiArt
    {
        public static void Show()
        {
            // Set text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Display ASCII art banner
            Console.WriteLine(@"
╔══════════════════════════════════════════════════════════════╗
║        ░█████╗░██╗░░░██╗██████╗░███████╗██████╗░             ║
║        ██╔══██╗╚██╗░██╔╝██╔══██╗██╔════╝██╔══██╗             ║
║        ██║░░╚═╝░╚████╔╝░██████╦╝█████╗░░██████╔╝             ║
║        ██║░░██╗░░╚██╔╝░░██╔══██╗██╔══╝░░██╔══██╗             ║
║        ╚█████╔╝░░░██║░░░██████╦╝███████╗██║░░██║             ║
║        ░╚════╝░░░░╚═╝░░░╚═════╝░╚══════╝╚═╝░░                ║
║                 CYBERSECURITY AWARENESS BOT                  ║
║                  Stay Safe Online!                           ║
╚══════════════════════════════════════════════════════════════╝
");

            // Reset console color
            Console.ResetColor();
        }
    }
}
