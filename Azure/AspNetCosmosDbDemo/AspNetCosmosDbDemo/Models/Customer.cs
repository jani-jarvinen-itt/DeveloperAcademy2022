using Newtonsoft.Json;

namespace AspNetCosmosDbDemo.Models
{
    public class Customer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }
    }
}
