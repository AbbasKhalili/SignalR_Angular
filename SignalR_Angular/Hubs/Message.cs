using System;

namespace SignalR_Angular.Hubs
{
    public class Message
    {
        public string clientuniqueid { get; set; }
        public string type { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
    }
}