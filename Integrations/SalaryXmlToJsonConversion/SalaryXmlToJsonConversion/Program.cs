using SalaryXmlToJsonConversion;
using System.Xml.Linq;

Console.WriteLine("Starting salary XML to JSON conversion.");

// step 1, read the salary data
string filename = "..\\..\\..\\Salaries.xml";
XDocument xmlDoc = XDocument.Load(filename);
var employees = xmlDoc.Descendants("palkka") // LINQ to XML
               .Select(x => new EmployeeData()
               {
                   Name = (string)x.Descendants("nimi").First(),
                   MonthlySalaryEuros = (double)x.Descendants("kuukausittain").First(),
                   HireDate = (string)x.Descendants("työsuhdealkoi").FirstOrDefault() ?? ""
               });

foreach (var employee in employees)
{
    Console.WriteLine($"{employee.Name} -> {employee.MonthlySalaryEuros}.");
}

Console.WriteLine("Conversion completed.");
