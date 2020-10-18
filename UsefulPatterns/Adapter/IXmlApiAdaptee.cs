using System.Xml.Linq;

namespace UsefulPatterns.Adapter
{
    public interface IXmlApiAdaptee
    {
        XDocument GetProducts();
    }
}