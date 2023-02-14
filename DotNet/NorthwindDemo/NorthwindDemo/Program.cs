using Microsoft.Data.SqlClient;

// open the connection to the Northwind database
Console.WriteLine("Starting to connect to the Northwind database.");
string connectionString = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;";
SqlConnection connection = new(connectionString);
connection.Open();
Console.WriteLine("Connection open!");

// execute an SQL query against the database
string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
SqlCommand command = new(sql, connection);

SqlDataReader reader = command.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["CompanyName"]);
}

Console.WriteLine("---------");
Console.WriteLine("Data has been read.");
