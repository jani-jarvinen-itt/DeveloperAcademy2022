string filename = "C:\\DeveloperAcademy\\Code\\JavaScript\\Numbers.txt";
string[] lines = File.ReadAllLines(filename);

int sum = 0;
try
{
    foreach (string line in lines)
    {
        int number = int.Parse(line);
        sum += number;
    }
}
catch
{
    Console.WriteLine("Error while processing numbers file.");
}

Console.WriteLine(sum);
