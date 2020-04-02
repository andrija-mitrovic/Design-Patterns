using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Team : IResource
    {
        private List<IResource> _resources = new List<IResource>();

        public void Add(IResource resource)
        {
            _resources.Add(resource);
        }

        public void Deploy()
        {
            foreach (var resource in _resources)
                resource.Deploy();
        }
    }
}
