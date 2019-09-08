using System.Threading.Tasks;

namespace MessagesClient
{
    public interface IMessageClient
    {
        Task SendMessageAsync(IMessage message);
    }
}