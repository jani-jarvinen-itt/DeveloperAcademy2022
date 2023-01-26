using System.Text;

/* With the "string" datatype:
 * 
 * 100K iterations   -> 0,65 seconds
 * 200K iterations   -> 3,1 seconds
 * 500K iterations   -> 32,0 seconds. */
/*
string data = "";
DateTime start = DateTime.Now;
Console.WriteLine("Starting string operations.");
const int NumberOfIterations = 500_000;
for (int counter = 0; counter < NumberOfIterations; counter++)
{
    data += "A";
}
DateTime stop = DateTime.Now;
Console.WriteLine("Completed string operations.");
Console.WriteLine(data.Length);
*/

// 500K iterations   -> 0,015 seconds
StringBuilder data = new();
DateTime start = DateTime.Now;
Console.WriteLine("Starting string operations.");
const int NumberOfIterations = 500_000;
for (int counter = 0; counter < NumberOfIterations; counter++)
{
    data.Append("A");
}
string final = data.ToString();
DateTime stop = DateTime.Now;
Console.WriteLine("Completed string operations.");
Console.WriteLine(final.Length);

// calculate time taken
TimeSpan diff = stop - start;
Console.WriteLine(diff.TotalSeconds);
