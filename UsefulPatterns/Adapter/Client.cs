using System;
using Newtonsoft.Json;

namespace UsefulPatterns.Adapter
{
    public class Client
    {
        private readonly IXmlApiAdaptee xmlApiAdaptee;
        private readonly IAdapter adapter;

        public Client(
            IXmlApiAdaptee xmlApiAdaptee,
            IAdapter adapter)
        {
            this.xmlApiAdaptee = xmlApiAdaptee;
            this.adapter = adapter;
        }

        public void PrintProductsXml()
        {
            var result = this.xmlApiAdaptee.GetProducts();
            var jsonFormat = JsonConvert.SerializeObject(result, Formatting.Indented);

            Console.WriteLine("Json format:");
            Console.WriteLine(jsonFormat);
        }

        public void PrintProductsJson()
        {
            var result = this.adapter.GetProducts();

            Console.WriteLine("Json format:");
            Console.WriteLine(result);
        }
    }
}