
using System;
using System.Globalization;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        //server method
        public void Send(string username, string message)
        {
            //js method
            Clients.All.Receive(username, message);
            Log(DateTime.Now.ToString(CultureInfo.InvariantCulture));
        }

        //server method
        public void Log(string info)
        {
            //js method
            Clients.All.Log(info);
        }
    }
}