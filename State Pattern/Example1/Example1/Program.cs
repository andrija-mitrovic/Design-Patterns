﻿using System;
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
            Canvas canvas = new Canvas();
            canvas.SetTool(new SelectionTool());
            canvas.MouseUp();
            canvas.MouseDown();

            Console.ReadLine();
        }
    }
}