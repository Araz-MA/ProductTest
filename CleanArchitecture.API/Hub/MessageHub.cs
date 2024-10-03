using Microsoft.AspNetCore.SignalR;

namespace CleanArchitecture.API.Hub
{
    public class MessageHub : Hub<IMessageHubClient>
    {        
        
        public override Task OnConnectedAsync()
        {            
            Clients.All.SendWelcomeMessageToClient("karbar aziz", "Salam Khosh omadi").GetAwaiter().GetResult();
            return base.OnConnectedAsync();
        }
         // instal nlog 1یبلیبل
         //set n log 2998dfsdfsdf
        public override Task OnDisconnectedAsync(Exception? exception) 
        {                      
            return base.OnDisconnectedAsync(exception);
        }

        public async Task CallFromClient(string str)
        {
            await Clients.Others.SendMessageToOther(str);
        }

    }
}
