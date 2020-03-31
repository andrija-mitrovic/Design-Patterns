using Example2.Gmail;
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
            EmailClient client = new EmailClient();
            client.AddProvider(new GmailAdapter(new GmailClient()));
            client.DownloadEmails();

            Console.ReadLine();
        }
    }
}
