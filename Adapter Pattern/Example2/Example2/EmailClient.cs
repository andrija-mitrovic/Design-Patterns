using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class EmailClient
    {
        private List<IEmailProvider> providers = new List<IEmailProvider>();

        public void AddProvider(IEmailProvider provider)
        {
            providers.Add(provider);
        }

        public void DownloadEmails()
        {
            foreach(var provider in providers)
                provider.DownloadEmails();
        }
    }
}
