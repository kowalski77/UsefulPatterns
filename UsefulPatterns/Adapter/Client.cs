using System;

namespace UsefulPatterns.Adapter
{
    public class Client
    {
        private readonly XmlApiAdaptee xmlApiAdaptee;
        private readonly IAdapter adapter;

        public Client(
            XmlApiAdaptee xmlApiAdaptee,
            IAdapter adapter)
        {
            this.xmlApiAdaptee = xmlApiAdaptee;
            this.adapter = adapter;
        }

        public void PrintProductsXml()
        {
            var result = this.xmlApiAdaptee.GetProducts();

            Console.WriteLine("Xml format:");
            Console.WriteLine(result);
        }

        public void PrintProductsJson()
        {
            var result = this.adapter.GetProducts();

            Console.WriteLine("Json format:");
            Console.WriteLine(result);
        }
    }
}