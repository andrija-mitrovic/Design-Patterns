using Example2.Gmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class GmailAdapter : IEmailProvider
    {
        private readonly GmailClient _gmailClient;
        public GmailAdapter(GmailClient gmailClient)
        {
            _gmailClient = gmailClient;
        }
        public void DownloadEmails()
        {
            _gmailClient.Connect();
            _gmailClient.GetEmails();
            _gmailClient.Disconnect();
        }
    }
}
