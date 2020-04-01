using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;
        public Task()
        {
            _auditTrail = new AuditTrail();
        }

        public void Execute()
        {
            _auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
