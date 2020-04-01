using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Window
    {
        public void Close()
        {
            OnClosed();
            Console.WriteLine("Removing the window from the screen");
            OnClosing();
        }
        protected virtual void OnClosing() { }
        protected virtual void OnClosed() { }
    }
}
