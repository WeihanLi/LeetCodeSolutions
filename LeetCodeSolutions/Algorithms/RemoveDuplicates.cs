using System.Linq;

namespace LeetCodeSolutions.Algorithms
{
    public class RemoveDuplicates
    {
        public static int Solution1(int[] nums)
        {
            nums = nums.Distinct().ToArray();
            return nums.Length;
        }
    }
}
