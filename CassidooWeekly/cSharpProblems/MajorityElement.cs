namespace cSharpProblems;

public class MajorityElement
{
    public static void MajorityElementMain()
    {
        Console.WriteLine(GetMajorityElement(new int[] {3,1,4,1}));
        Console.WriteLine(GetMajorityElement(new int[] {33,44,55,66,77}));
        Console.WriteLine(GetMajorityElement(new int[] {1,2,3,4}));
        
    }

    public static string GetMajorityElement(int[] nums)
    {
        // create variables to hold count of odd and even elements
        var oddCount = 0;
        var evenCount = 0;

        // create a data structure to hold the count of each number
        var numCount = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (numCount.ContainsKey(num))
            {
                numCount[num]++;
            }
            else
            {
                numCount.Add(num, 1);
            }
            
            if (num % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        
        // iterate through the dictionary and find the number with the highest count
        var highestCount = -1;
        var highestCountNum = 0;
        bool tie = false;
        
        foreach (var num in numCount)
        {
            if (num.Value == highestCount)
            {
                tie = true;
            }
            if (num.Value > highestCount)
            {
                highestCount = num.Value;
                highestCountNum = num.Key;
                tie = false;
            }
            
        }

        if (!tie) return highestCountNum.ToString();
        
            
        if (evenCount > oddCount)
        {
            return "Majority even";
        } 
        else if (evenCount < oddCount)
        {
            return "Majority odd";
        }
        else
        {
            return "No majority";
        }
    }
}