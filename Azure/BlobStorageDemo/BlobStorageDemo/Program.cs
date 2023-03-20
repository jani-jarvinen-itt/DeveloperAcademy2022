using System.Text;
using System.Text.Json;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using BlobStorageDemo;

Console.WriteLine("Starting to access Azure Blob Storage.");

// TODO: store connection string in a configuration file, not in source code
string connectionString = "DefaultEndpointsProtocol=https;AccountName=developeracademy;AccountKey=Fh4NnaUemJ9kwKcJhHkqJIyM00dk0RqBEfJWkvOBLfOfwqFJPkkrqmVhWpZ7s9jb8k40No4++Qj++AStTCJbQg==;EndpointSuffix=core.windows.net";

/*
// create container
BlobContainerClient container = new(connectionString, "jani-testing");
await container.CreateAsync();
Console.WriteLine("Contained created.");
*/

/*
// define data to store
Customer c = new()
{
    Id = 1234,
    Name = "John Doe",
    Country = "Finland"
};

// upload a file
BlobContainerClient container = new(connectionString, "jani-testing");
string myData = JsonSerializer.Serialize(c);
await UploadBlobData(container, "Customer.json", myData);
*/

// download customer data from the blob storage
BlobContainerClient container = new(connectionString, "jani-testing");
Customer? c = await DownloadCustomerObject(container, "Customer.json");

Console.WriteLine("Application closing.");

static async Task UploadBlobData(BlobContainerClient container, string blobName, string data)
{
    BlobClient blob = container.GetBlobClient(blobName);
    MemoryStream stream = new();
    byte[] bytes = Encoding.UTF8.GetBytes(data);
    stream.Write(bytes, 0, bytes.Length);
    stream.Position = 0;

    await blob.UploadAsync(stream);
    Console.WriteLine("Upload of blob succeeded.");
}

static async Task<Customer?> DownloadCustomerObject(BlobContainerClient container, string jsonBlobName)
{
    Customer readCustomer = null!;

    BlobClient blob = container.GetBlobClient(jsonBlobName);
    Azure.Response<BlobDownloadResult> result = await blob.DownloadContentAsync();
    if (!result.GetRawResponse().IsError)
    {
        readCustomer = result.Value.Content.ToObjectFromJson<Customer>();
        Console.WriteLine(readCustomer.Name);
    }
    else
    {
        Console.WriteLine("Could not read customer object from blob storage.");
    }

    // return what we got
    return readCustomer;
}
