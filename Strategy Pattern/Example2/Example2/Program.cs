using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatClient chat = new ChatClient(new DesEncription());
            chat.Send("Hello World");

            Console.ReadLine();
        }
    }
}
