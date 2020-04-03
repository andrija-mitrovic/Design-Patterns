using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class CompressedCloudStream : IStream
    {
        private readonly IStream _stream;
        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var compressed = Compress(data);
            _stream.Write(compressed);
        }

        public string Compress(string data) => data.Substring(0, 3);
    }
}
