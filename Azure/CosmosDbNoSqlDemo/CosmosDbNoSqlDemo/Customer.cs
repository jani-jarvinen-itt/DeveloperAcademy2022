using Newtonsoft.Json;

namespace CosmosDbNoSqlDemo
{
    public class Customer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }
    }
}
