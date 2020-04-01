using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class ChatWindow:Window
    {
        protected override void OnClosed()
        {
            Console.WriteLine("Disconnecting from the server...");
        }

    }
}
