using System;

namespace MessagesClient
{
    public class RabbitMqConfiguration
    {
        public Uri Host { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}