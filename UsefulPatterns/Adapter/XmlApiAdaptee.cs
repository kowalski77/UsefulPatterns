using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace UsefulPatterns.Adapter
{
    // Adaptee
    public class XmlApiAdaptee : IXmlApiAdaptee
    {
        public XDocument GetProducts()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Products");
            var xAttributes = GetData()
                .Select(m => new XElement("Product",
                    new XAttribute("Id", m.Id),
                    new XAttribute("Name", m.Name),
                    new XAttribute("Description", m.Description),
                    new XAttribute("Price", m.Price)));
            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            return xDocument;
        }

        private static IEnumerable<Product> GetData()
        {
            return new List<Product>(new[]
            {
                new Product
                {
                    Id = 1, Name = "Product1", Description = "Description1", Price = 11
                },
                new Product
                {
                    Id = 2, Name = "Product2", Description = "Description2", Price = 12
                },
                new Product
                {
                    Id = 3, Name = "Product2", Description = "Description3", Price = 13
                }
            });
        }
    }
}