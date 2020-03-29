using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class AudioStorage
    {
        public void Store(string fileName, ICompression compression)
            => compression.Compress(fileName);
    }
}
