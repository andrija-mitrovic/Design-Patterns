using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class ChatClient
    {
        private IEncryption _encryptionAlgorithm;

        public ChatClient(IEncryption encryptionAlgorithm)
        {
            _encryptionAlgorithm = encryptionAlgorithm;
        }

        public void Send(string message)
        {
            var text = _encryptionAlgorithm.Encrypt(message);

            Console.WriteLine("Sending the encrypted message...");
        }
    }
}
