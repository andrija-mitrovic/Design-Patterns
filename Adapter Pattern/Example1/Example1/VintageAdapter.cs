using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class VintageAdapter : IFilter
    {
        private VintageFilter _vintageFilter;

        public VintageAdapter(VintageFilter vintageFilter)
        {
            _vintageFilter = vintageFilter;
        }

        public void Apply(Image image)
        {
            _vintageFilter.Init();
            _vintageFilter.Render(image);
        }
    }
}
