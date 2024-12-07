using System;
using System.Text.RegularExpressions;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("");
        string input = Console.ReadLine();
        string pattern = @"\d{2}[-/]\d{2}[-/]\d{4}";

        // Check if the word "match" is in the input string
        if (Regex.IsMatch(input, pattern)) {
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match); // Output: Extracted URL
            }
        }
    }
}