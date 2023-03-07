using SalaryXmlToJsonConversion;
using System.Xml.Linq;
using System.Text.Json;

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

// step 2, read currency rate from XML file from ECB
filename = "..\\..\\..\\Currency rates.xml";
xmlDoc = XDocument.Load(filename);
XNamespace gesmes = "http://www.gesmes.org/xml/2002-08-01";
XNamespace ns = "http://www.ecb.int/vocabulary/2002-08-01/eurofxref";
var cubes = xmlDoc.Descendants(ns + "Cube")
               .Where(x => x.Attribute("currency") != null)
               .Select(x => new
               {
                   Currency = (string)x.Attribute("currency") ?? "",
                   Rate = (double)x.Attribute("rate")
               });

// find the USD currency rate
double usdRate = 0.0;
foreach (var result in cubes)
{
    // Console.WriteLine($"{result.Currency}: {result.Rate}");
    if (result.Currency == "USD")
    {
        usdRate = result.Rate;
        Console.WriteLine($"Found {result.Currency} currency rate: {result.Rate}.");

        break;
    }
}

// step 3, data conversion
List<EmployeeDestinationFormat> destinationList = new();
foreach (EmployeeData employee in employees)
{
    Console.WriteLine($"{employee.Name} -> {employee.MonthlySalaryEuros}.");

    // conversion to destionation format
    EmployeeDestinationFormat destionation = new()
    {
        personName = employee.Name,
        hireDate = employee.HireDate,
        salary = new()
        {
            monthly = employee.MonthlySalaryEuros * usdRate
        }
    };
    destinationList.Add(destionation);
}

// step 4, serialize destination data to JSON
string json = JsonSerializer.Serialize(destinationList,
    new JsonSerializerOptions() { WriteIndented = true });

Console.WriteLine("---------------");
Console.WriteLine(json);
Console.WriteLine("---------------");

Console.WriteLine("Conversion completed.");
