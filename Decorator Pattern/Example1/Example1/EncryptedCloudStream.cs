using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class EncryptedCloudStream : IStream
    {
        private readonly IStream _stream;
        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            var encrypt = Encrypt(data);
            _stream.Write(encrypt);
        }

        private string Encrypt(string data) => "!@#$#$())*&^&#^";
    }
}
