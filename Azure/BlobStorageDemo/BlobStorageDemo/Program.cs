using Azure.Storage.Blobs;
using System.IO;
using System.Text;

Console.WriteLine("Starting to access Azure Blob Storage.");

// TODO: store connection string in a configuration file, not in source code
string connectionString = "DefaultEndpointsProtocol=https;AccountName=developeracademy;AccountKey=Fh4NnaUemJ9kwKcJhHkqJIyM00dk0RqBEfJWkvOBLfOfwqFJPkkrqmVhWpZ7s9jb8k40No4++Qj++AStTCJbQg==;EndpointSuffix=core.windows.net";

// create container
BlobContainerClient container = new(connectionString, "jani-testing");
await container.CreateAsync();
Console.WriteLine("Contained created.");

// upload a file
BlobClient blob = container.GetBlobClient("my-first-blob.txt");
string myData = "Hello, Azure from C#!";
MemoryStream stream = new();
byte[] bytes = Encoding.UTF8.GetBytes(myData);
stream.Write(bytes, 0, bytes.Length);
stream.Position = 0;

await blob.UploadAsync(stream);
Console.WriteLine("Upload of blob succeeded.");

Console.WriteLine("Application closing.");
