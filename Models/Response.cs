namespace CybersecurityChatbot.Models
{
    public class Response
    {
        public string Keyword { get; set; } = "";
        public string Reply { get; set; } = "";

        public Response() { }

        public Response(string keyword, string reply)
        {
            Keyword = keyword ?? "";
            Reply = reply ?? "";
        }
    }
}
