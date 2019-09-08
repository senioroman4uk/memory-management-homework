using System.Threading.Tasks;
using MassTransit;

namespace MessagesClient
{
    internal class MessageClient : IMessageClient
    {
        private readonly IPublishEndpoint _sendEndpoint;

        public MessageClient(IPublishEndpoint sendEndpoint)
        {
            _sendEndpoint = sendEndpoint;
        }

        public Task SendMessageAsync(IMessage message)
        {
            return _sendEndpoint.Publish(message);
        }
    }
}