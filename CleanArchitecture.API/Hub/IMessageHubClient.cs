namespace CleanArchitecture.API.Hub
{
    public interface IMessageHubClient
    {
        Task SendWelcomeMessageToClient(string user, string message);
        Task SendMessageToOther(string message);
    }
}
