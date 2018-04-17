using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace signalrmessage.Models
{
	public class MessageHub : Hub
	{
		public void  SendMessage(string userName, string userMessage)
        {
			this.Clients.All.broadcastMessage(userName, userMessage);
        }
	}
}