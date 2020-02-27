using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions.Algorithms
{
    /// <summary>
    /// 两数之和
    /// https://leetcode-cn.com/problems/two-sum/description/
    /// </summary>
    public class TwoSum
    {
        /// <summary>
        /// for ... for
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] Solution1(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }
            throw new ArgumentException("No two sum solution");
        }

        /// <summary>
        /// List
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] Solution2(int[] nums, int target)
        {
            var list = nums.ToList();
            for (var i = 0; i < nums.Length - 1; i++)
            {
                var idx = list.FindIndex(i + 1, _ => _ + nums[i] == target);
                if (idx > -1)
                {
                    return new[] { i, idx };
                }
            }
            throw new ArgumentException("No two sum solution");
        }

        /// <summary>
        /// for + Dictionary
        /// [Better Solution]
        /// </summary>
        public static int[] Solution3(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>(nums.Length);
            for (var i = 0; i < nums.Length; i++)
            {
                var ano = target - nums[i];
                if (dic.ContainsKey(ano))
                {
                    return new[] { dic[ano], i };
                }
                dic.Add(nums[i], i);
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
