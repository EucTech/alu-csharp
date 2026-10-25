using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Provides basic math operations.</summary>
    public class Operations
    {
        /// <summary>Finds the max integer in a list of integers.</summary>
        /// <param name="nums">The list of integers.</param>
        /// <returns>The max integer in the list, or 0 if the list is empty or null.</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            int max = nums[0];

            foreach (int num in nums)
            {
                if (num > max)
                    max = num;
            }

            return max;
        }
    }
}
