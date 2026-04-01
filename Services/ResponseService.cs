using CybersecurityChatbot.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace CybersecurityChatbot.Services
{
    public class ResponseService
    {
        private readonly List<Response> _responses;

        public ResponseService(List<Response> responses)
        {
            _responses = responses;
        }

        public string GetResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "I don't understand. Ask about cybersecurity.";

            // 1️⃣ Remove punctuation
            string cleanInput = Regex.Replace(input.ToLower(), @"[^\w\s]", "");

            // 2️⃣ Match keywords (multi-word included)
            var match = _responses.FirstOrDefault(r =>
            {
                string cleanKeyword = Regex.Replace(r.Keyword.ToLower(), @"[^\w\s]", "");
                return cleanInput.Contains(cleanKeyword);
            });

            return match != null
                ? match.Reply
                : "I don't understand. Ask about cybersecurity.";
        }
    }
}