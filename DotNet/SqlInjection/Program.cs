Console.WriteLine("Please enter a country name:");
string country = Console.ReadLine() ?? "";
string sql = "SELECT * FROM Customers WHERE " +
             "Country = '" + country + "'";
Console.WriteLine(sql);
