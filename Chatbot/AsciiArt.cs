namespace CybersecurityChatbot.Chatbot
{
    public static class AsciiArt
    {
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"
╔══════════════════════════════════════════════════════════════╗
║        ░█████╗░██╗░░░██╗██████╗░███████╗██████╗░             ║
║        ██╔══██╗╚██╗░██╔╝██╔══██╗██╔════╝██╔══██╗             ║
║        ██║░░╚═╝░╚████╔╝░██████╦╝█████╗░░██████╔╝             ║
║        ██║░░██╗░░╚██╔╝░░██╔══██╗██╔══╝░░██╔══██╗             ║
║        ╚█████╔╝░░░██║░░░██████╦╝███████╗██║░░██║             ║
║        ░╚════╝░░░░╚═╝░░░╚═════╝░╚══════╝╚═╝░░                ║
║                 CYBERSECURITY AWARENESS BO                   ║
║                  Stay Safe Online!                           ║
╚══════════════════════════════════════════════════════════════╝
");

            Console.ResetColor();
        }
    }
}