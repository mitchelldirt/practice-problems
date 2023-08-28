using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(isAnagram("cristian", "Cristina")); // true
        Console.WriteLine(isAnagram("Dave Barry", "Ray Adverb")); // true
        Console.WriteLine(isAnagram("Nope", "Note")); // false
    }
    public static bool isAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length) return false;
        var dict = new Dictionary<char, int>();
        foreach (var c in s1.ToLower())
        {
            if (dict.ContainsKey(c)) dict[c]++;
            else dict[c] = 1;
        }
        foreach (var c in s2.ToLower())
        {
            if (!dict.ContainsKey(c)) return false;
            dict[c]--;
            if (dict[c] < 0) return false;
        }
        return true;
    }
}
