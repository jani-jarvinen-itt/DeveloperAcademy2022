// Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir NorthwindModels
// Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=AdventureWorks;Trusted_Connection=True;Encrypt=no;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir AdventureModels
using nw = NorthwindCustomersToAdventureWorks.NorthwindModels;
using Microsoft.EntityFrameworkCore;
using NorthwindCustomersToAdventureWorks.NorthwindModels;

Console.WriteLine("Starting to read Northwind customer information.");

NorthwindContext nwContext = new();
foreach (nw.Customer cust in nwContext.Customers)
{
    Console.WriteLine(cust.CompanyName);
}

Console.WriteLine("Processing complete.");
