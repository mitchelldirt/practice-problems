using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(ReverseVowels("string")); // 'rtsng'
        Console.WriteLine(ReverseVowels("hello world!")); // 'w hllrld!'

    }
    public static string ReverseVowels(string s1)
    {
        string vowels = "aeiou";
        List<char> result = new List<char>();

        for (int i = 0; i < s1.Length; i++)
        {
            string currentChar = s1[i].ToString();
            if (vowels.Contains(currentChar))
            {
                result.Reverse();
            }
            else
            {
                result.Add(s1[i]);
            }
        }
        return string.Join("", result);
    }
}
