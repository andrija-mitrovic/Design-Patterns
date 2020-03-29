using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class DesEncription : IEncryption
    {
        public string Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using DES");
            return "Encrypted text";
        }
    }
}
