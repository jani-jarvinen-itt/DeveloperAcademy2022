using EntityDemo2.Models;

Console.WriteLine("Starting Entity Framework Demo 2.");

NorthwindContext context = new();
/*
int numberOfCustomers = context.Customers.Count();
Console.WriteLine(numberOfCustomers);
*/

/*
// Warning: fetches all customer rows to the client C# application
foreach (var customer in context.Customers)
{
    if (customer.Country == "Finland")
    {
        Console.WriteLine(customer.CompanyName);
    }
}
*/

// LINQ query to the Northwind database
var finnishCustomer = (from c in context.Customers
                       where c.Country == "Finland"
                       select c).ToList();
foreach (var customer in finnishCustomer)
{
    Console.WriteLine(customer.CompanyName);
}
