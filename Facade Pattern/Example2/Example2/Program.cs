﻿using System;
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
            TweeterService service = new TweeterService("appKey", "secret");
            service.GetRecentTweets();

            Console.ReadLine();
        }
    }
}
