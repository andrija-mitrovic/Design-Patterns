using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioStorage audio = new AudioStorage();
            audio.Store("audio", new Mp4Compression());
            audio.Store("audio", new Mp4Compression());

            Console.ReadLine();
        }
    }
}
