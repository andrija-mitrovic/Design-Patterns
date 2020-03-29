using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Mp4Compression : ICompression
    {
        public void Compress(string fileName)
            => Console.WriteLine("Compressing using MP4");
    }
}
