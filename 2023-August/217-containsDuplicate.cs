using System;
using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> uniqueNums = new HashSet<int>(nums);
        if (uniqueNums.Count == nums.Length)
        {
            return false;
        }
        return true;
    }
}