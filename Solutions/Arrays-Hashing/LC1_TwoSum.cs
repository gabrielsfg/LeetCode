using System;

public class LC1_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int missing = target - nums[i];

            int missingIndex = Array.IndexOf(nums, missing, i + 1);

            if (missingIndex != -1 && missingIndex != i)
            {
                Console.WriteLine($"[{i}, {missingIndex}]");
                return new int[] { i, missingIndex };
            }
        }
        return new int[] { -1, -1 };
    }
}
}
