namespace CybersecurityChatbot.Models
{
    public class Response
    {
        // The keyword or trigger phrase used to match user input
        public string Keyword { get; set; } = "";

        // The reply the chatbot will return when the keyword is matched
        public string Reply { get; set; } = "";

        // Default constructor (required for deserialization, e.g., from JSON)
        public Response() { }

        // Constructor to quickly create a response with a keyword and reply
        public Response(string keyword, string reply)
        {
            Keyword = keyword ?? "";
            Reply = reply ?? "";
        }
    }
}
