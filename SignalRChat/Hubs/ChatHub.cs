
using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        //server method
        public void Send(string username, string message)
        {
            //js method
            Clients.All.Receive(HttpUtility.HtmlEncode(username), HttpUtility.HtmlEncode(message), DateTime.Now.ToString("yyyyMMddhhmmss"));
        }
    }
}