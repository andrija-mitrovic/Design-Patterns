using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class JsonConverter
    {
        private readonly IEnumerable<Manufacturer> _manufacturers;

        public JsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {
            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }
}
