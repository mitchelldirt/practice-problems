
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var result = SortAndGroup(new int[] { 4, 3, 2, 1, 5, 7, 8, 9 });

        foreach (var group in result)
        {
            foreach (var num in group)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
    public static int[][] SortAndGroup(int[] ints)
    {
        List<int> evens = new();
        List<int> odds = new();

        foreach (var num in ints)
        {
            if (num % 2 == 0)
            {
                evens.Add(num);
            }
            else
            {
                odds.Add(num);
            }
        }

        evens.Sort();
        odds.Sort();


        return new int[][] { evens.ToArray(), odds.ToArray() };
    }
}
