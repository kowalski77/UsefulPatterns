using Newtonsoft.Json;

namespace UsefulPatterns.Adapter
{
    // Concrete Adapter
    public class JsonAdapter : IAdapter
    {
        private readonly IXmlApiAdaptee xmlApiAdaptee;

        public JsonAdapter(IXmlApiAdaptee xmlApiAdaptee)
        {
            this.xmlApiAdaptee = xmlApiAdaptee;
        }

        public string GetProducts()
        {
            var products = this.xmlApiAdaptee.GetProducts();
            var result = JsonConvert.SerializeObject(products, Formatting.Indented);

            return result;
        }
    }
}