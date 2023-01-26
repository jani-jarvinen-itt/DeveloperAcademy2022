using AspNetMvcUserTable.Models;

namespace AspNetMvcUserTable.Utilities
{
    public class CsvParser
    {
        public List<UserDetails> ReadUserList()
        {
            string filename = "C:\\DeveloperAcademy\\Code\\DotNet\\Users.csv";
            string[] lines = File.ReadAllLines(filename);

            List<UserDetails> results = new();
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                UserDetails userDetails = new()
                {
                    UserName = parts[0],
                    UserEmail = parts[1]
                };

                results.Add(userDetails);
            }

            return results;
        }
    }
}
