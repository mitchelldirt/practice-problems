using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(NumOfStairs(6)); // 3
        Console.WriteLine(NumOfStairs(9)); // also 3
        Console.WriteLine(NumOfStairs(10)); // 10
    }

    private static int NumOfStairs(int totalBlocks)
    {
        int totalSteps = 0;
        int blocksNeeded = 1;

        while (totalBlocks >= blocksNeeded)
        {
            totalBlocks -= blocksNeeded;

            totalSteps++;
            blocksNeeded++;
        }

        return totalSteps;
    }
}
