namespace MessagesClient
{
    public interface IMessageClientFactory
    {
        IMessageClient Create();
    }
}