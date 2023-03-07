// Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir NorthwindModels
// Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=AdventureWorks;Trusted_Connection=True;Encrypt=no;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir AdventureModels
using NorthwindCustomersToAdventureWorks.NorthwindModels;
using nw = NorthwindCustomersToAdventureWorks.NorthwindModels;
using NorthwindCustomersToAdventureWorks.AdventureModels;
using aw = NorthwindCustomersToAdventureWorks.AdventureModels;

Console.WriteLine("Starting to read Northwind customer information.");

NorthwindContext nwContext = new();
AdventureWorksContext awContext = new();
foreach (nw.Customer cust in nwContext.Customers)
{
    Console.WriteLine(cust.CompanyName);

    aw.Store newStore = new()
    {
        // TODO: BusinessEntityId
        Name = cust.CompanyName
    };
    awContext.Stores.Add(newStore);
}

awContext.SaveChanges();
Console.WriteLine("Processing complete.");
