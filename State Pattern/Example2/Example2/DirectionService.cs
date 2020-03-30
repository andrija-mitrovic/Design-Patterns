using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class DirectionService
    {
        private ITravelMode _travelMode;
        public DirectionService(ITravelMode travelMode)
        {
            _travelMode = travelMode;
        }

        public object GetDirection()
            => _travelMode.GetDirection();

        public object GetEta()
            => _travelMode.GetEta();
    }
}
