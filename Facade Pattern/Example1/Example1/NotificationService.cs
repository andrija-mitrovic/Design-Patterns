using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            NotificationServer server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("appID", "key");
            server.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}
