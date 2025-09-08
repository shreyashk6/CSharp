using System;

public class ReverseWords
{
    public static string ReverseWordsInString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return ""; // Or throw an ArgumentNullException if you prefer
        }

        string[] words = input.Split('-', ' ');
        
        Array.Reverse(words);
        return string.Join(" ", words);
        
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string separated by hyphens:");
        string inputString = Console.ReadLine();

        string reversedString = ReverseWordsInString(inputString);
        Console.WriteLine("Reversed string: " + reversedString);
    }
}