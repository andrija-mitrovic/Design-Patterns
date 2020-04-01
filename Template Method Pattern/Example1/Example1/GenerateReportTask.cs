using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class GenerateReportTask : Task
    {
        protected override void DoExecute()
            => Console.WriteLine("Generate report");
    }
}
