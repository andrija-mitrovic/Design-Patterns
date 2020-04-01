using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Button
    {
        private readonly ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
            => _command.Execute();
    }
}
