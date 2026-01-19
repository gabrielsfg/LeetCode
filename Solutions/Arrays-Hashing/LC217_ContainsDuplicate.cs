using System;
using System.Collections.Generic;

public class LC217_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                return true;
        }
        return false;
    }

    public bool ContainsDuplicateHash(int[] nums)
    {
        var hash = new HashSet<int>();
        foreach (int i in nums)
            if (!hash.Add(i)) return true;
        return false;
    }
}