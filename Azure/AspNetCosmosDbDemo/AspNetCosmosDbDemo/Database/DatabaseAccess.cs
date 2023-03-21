using AspNetCosmosDbDemo.Models;
using Microsoft.Azure.Cosmos;

namespace AspNetCosmosDbDemo.Database
{
    public class DatabaseAccess
    {
        // TODO: store the primary key in a configuration file
        private string EndpointUri = "https://developeracademy.documents.azure.com:443/";
        private string PrimaryKey = "anVoQczyuCH2Gg16aUAHTTKPObRlpFBw4q66bK8fz9OjSZWqZ5zZpSQ7btU24y64m1LmCSjVdRDVACDbEfu2vw==";

        public async Task<Customer> ReadCustomer(string customerId)
        {
            // create the client
            const string DatabaseId = "Customers-Jani";
            const string ContainerId = "Customers";
            CosmosClient cosmosClient = new(EndpointUri, PrimaryKey);
            DatabaseResponse result = await cosmosClient.CreateDatabaseIfNotExistsAsync(DatabaseId);
            var database = result.Database;
            Container container = await database.CreateContainerIfNotExistsAsync(ContainerId, "/id");

            // read the customer object
            ItemResponse<Customer> response = await container.ReadItemAsync<Customer>(customerId, new PartitionKey(customerId));
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // display customer name
                Customer readCustomer = response.Resource;
                return readCustomer;
            }
            else
            {
                return null;
            }
        }
    }
}
