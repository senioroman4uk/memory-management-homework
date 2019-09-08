using MassTransit;

namespace MessagesClient
{
    internal class MessageClientFactory : IMessageClientFactory
    {
        private readonly RabbitMqConfiguration _rabbitMqConfiguration;

        public MessageClientFactory(RabbitMqConfiguration rabbitMqConfiguration)
        {
            _rabbitMqConfiguration = rabbitMqConfiguration;
        }

        public IMessageClient Create()
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(c => c.Host(_rabbitMqConfiguration.Host, hostConfiguration =>
            {
                hostConfiguration.Username(_rabbitMqConfiguration.Username);
                hostConfiguration.Password(_rabbitMqConfiguration.Password);
            }));
            
            return new MessageClient(bus);
        }
    }
}