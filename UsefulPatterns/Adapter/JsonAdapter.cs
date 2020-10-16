using System;
using System.Linq;
using Newtonsoft.Json;

namespace UsefulPatterns.Adapter
{
    // Concrete Adapter
    public class JsonAdapter : IAdapter
    {
        private readonly XmlApiAdaptee xmlApiAdaptee;

        public JsonAdapter(XmlApiAdaptee xmlApiAdaptee)
        {
            this.xmlApiAdaptee = xmlApiAdaptee;
        }

        public string GetProducts()
        {
            var products = this.xmlApiAdaptee.GetProducts()
                .Element("Products")
                ?.Elements("Product")
                .Select(x => new Product
                {
                    Id = Convert.ToInt32(x.Attribute("Id")?.Value),
                    Name = x.Attribute("Name")?.Value,
                    Description = x.Attribute("Description")?.Value,
                    Price = Convert.ToDecimal(x.Attribute("Price")?.Value)
                });

            var result  = JsonConvert.SerializeObject(products, Formatting.Indented);

            return result;
        }
    }
}