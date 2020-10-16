using System;

namespace UsefulPatterns.Adapter
{
    public class AdapterStarter
    {
        public void Run()
        {
            var client = new Client(new XmlApiAdaptee(), new JsonAdapter(new XmlApiAdaptee()));
            client.PrintProductsXml();
            Console.WriteLine();
            client.PrintProductsJson();
        }
    }
}