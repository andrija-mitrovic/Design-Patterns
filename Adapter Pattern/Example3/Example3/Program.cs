using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlToJsonAdapter adapter = new XmlToJsonAdapter(new XmlConverter());
            adapter.ConvertXmlToJson();


            Console.ReadLine();
        }
    }
}
