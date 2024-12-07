﻿using System;
using System.Text.RegularExpressions;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input string");
        string input = Console.ReadLine();
        //dd/mm/yyyy or dd-mm-yyyy
        string pattern = @"\d{2}[-/]\d{2}[-/]\d{4}";

        if (Regex.IsMatch(input, pattern)) {
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match); // Output: dd/mm/yyyy or dd-mm-yyyy
            }
        }
        else{
            Console.WriteLine("No matches found.");
        }
    }
}