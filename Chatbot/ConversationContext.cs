namespace CybersecurityChatbot.Chatbot
{
    // Stores data related to the current conversation session.
    public class ConversationContext
    {
        // Stores the user's name.
        public string UserName { get; set; } = "";

        // Stores the last topic the user asked about.
        public string LastTopic { get; set; } = "";
    }
}
