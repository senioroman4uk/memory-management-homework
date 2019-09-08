using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MessagesClient
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterMessagesClient(this IServiceCollection services, IConfiguration configuration)
        {
            var rabbitMqConfiguration = new RabbitMqConfiguration();
            configuration.Bind("RabbitMq", rabbitMqConfiguration);

            services.AddSingleton(rabbitMqConfiguration);
            services.AddSingleton<IMessageClientFactory, MessageClientFactory>();
        }
    }
}