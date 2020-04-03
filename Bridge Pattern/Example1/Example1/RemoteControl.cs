using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class RemoteControl
    {
        protected readonly IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
            => _device.TurnOn();

        public void TurnOff()
            => _device.TurnOff();
    }
}
