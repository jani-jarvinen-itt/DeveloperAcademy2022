using EntityDemo2.Models;

Console.WriteLine("Starting Entity Framework Demo 2.");

NorthwindContext context = new();
/*
int numberOfCustomers = context.Customers.Count();
Console.WriteLine(numberOfCustomers);
*/

foreach (var customer in context.Customers)
{
    if (customer.Country == "Finland")
    {
        Console.WriteLine(customer.CompanyName);
    }
}
