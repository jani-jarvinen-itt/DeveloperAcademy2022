using Microsoft.Data.SqlClient;

// open the connection to the Northwind database
try
{
	Console.WriteLine("Starting to connect to the Northwind database.");
	string connectionString = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;";
	using SqlConnection connection = new(connectionString);
	connection.Open();
	Console.WriteLine("Connection open!");

	// execute an SQL query against the database
	string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
    using SqlCommand command = new(sql, connection);

    // read the customer data
    using SqlDataReader reader = command.ExecuteReader();
	while (reader.Read())
	{
		Console.WriteLine(reader.GetString(1)); // second column
		Console.WriteLine(reader["CompanyName"]);
	}
	Console.WriteLine("---------");
	Console.WriteLine("Data has been read.");

	/*
	// housekeeping
	reader.Close();
	command.Dispose();
	connection.Close();
	*/
}
catch (Exception ex)
{
	Console.WriteLine("Cannot access database: " + ex.Message);
}
