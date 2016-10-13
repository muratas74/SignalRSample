
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public Timer Timer { get; set; }

        private void ServerClock(object state)
        {
            Clients.Caller.ServerClock(DateTime.UtcNow.ToString("O"));
        }

        public override Task OnConnected()
        {
            StartTime();
            return base.OnConnected();
        }

        public void StartTime()
        {
            if (Timer != null)
                return;

            Timer = new Timer(ServerClock, this, 0, 60000);
        }

        //server method
        public void Send(string username, string message)
        {
            //js method
            Clients.All.Receive(HttpUtility.HtmlEncode(username), HttpUtility.HtmlEncode(message), DateTime.UtcNow.ToString("O"));
        }
    }
}