string filename = "C:\\DeveloperAcademy\\Code\\JavaScript\\Numbers.txt";
string[] lines = File.ReadAllLines(filename);

int sum = 0;
foreach (string line in lines)
{
    try
    {
        int number = int.Parse(line);
        sum += number;
    }
    catch
    {
        Console.WriteLine($"Error while processing line \"{line}\".");
    }
}

Console.WriteLine(sum);
