using System;

namespace LeetCodeSolutions.Algorithms
{
    public class JumpGame
    {
        public static bool Solution1(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return true;
            }

            var n = 1;
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] >= n)
                {
                    n = 1;
                }
                else
                {
                    n++;
                }
                if (i == 0 && n > 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Solution2(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return true;
            }

            int start = 0, end = 0;
            while (start <= end)
            {
                // 能达到的最远的位置
                end = Math.Max(end, start + nums[start]);
                if (end >= nums.Length - 1)
                {
                    return true;
                }

                // 向后移动
                start++;
            }
            return end >= nums.Length - 1;
        }
    }
}
