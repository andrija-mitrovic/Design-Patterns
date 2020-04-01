using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class TransferMoneyTask : Task
    {
        protected override void DoExecute()
            => Console.WriteLine("Transfer money");
    }
}
