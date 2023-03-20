using CosmosDbNoSqlDemo;
using Microsoft.Azure.Cosmos;

Console.WriteLine("Starting to access Cosmos DB database in Azure.");

// TODO: store the primary key in a configuration file
const string EndpointUri = "https://developeracademy.documents.azure.com:443/";
const string PrimaryKey = "anVoQczyuCH2Gg16aUAHTTKPObRlpFBw4q66bK8fz9OjSZWqZ5zZpSQ7btU24y64m1LmCSjVdRDVACDbEfu2vw==";

// define the data
Customer c = new()
{
    Id = "1234",
    Name = "John Doe",
    Country = "Finland"
};

// create the client
const string DatabaseId = "Customers-Jani";
const string ContainerId = "Customers";
CosmosClient cosmosClient = new(EndpointUri, PrimaryKey);
Database database = await cosmosClient.CreateDatabaseIfNotExistsAsync(DatabaseId);
Container container = await database.CreateContainerIfNotExistsAsync(ContainerId, "/id");
Console.WriteLine("Connection to database is now open.");

// store customer information
// await StoreCustomer(c, container);

// read a customer object given an id
const string CustomerId = "1234";
await ReadCustomer(container, CustomerId);


Console.WriteLine("Application closing.");

static async Task StoreCustomer(Customer c, Container container)
{
    ItemResponse<Customer> response = await container.CreateItemAsync<Customer>(c, new PartitionKey(c.Id));
    Console.WriteLine($"New customer added to the database, id = {response.Resource.Id}.");
}

static async Task ReadCustomer(Container container, string customerId)
{
    ItemResponse<Customer> response = await container.ReadItemAsync<Customer>(customerId, new PartitionKey(customerId));
    if (response.StatusCode == System.Net.HttpStatusCode.OK)
    {
        // display customer name
        Customer readCustomer = response.Resource;
        Console.WriteLine(readCustomer.Name);
    }
    else
    {
        Console.WriteLine($"Could not find customer with id {customerId}.");
    }
}