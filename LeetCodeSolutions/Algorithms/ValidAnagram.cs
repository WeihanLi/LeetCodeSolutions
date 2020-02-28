using System.Linq;

namespace LeetCodeSolutions.Algorithms
{
    // https://leetcode-cn.com/problems/valid-anagram/
    public class ValidAnagram
    {
        /// <summary>
        /// 解决方案1
        /// Sort 之后比较
        /// </summary>
        /// <param name="s">s1</param>
        /// <param name="t">t1</param>
        /// <returns>isValid</returns>
        public static bool Solution1(string s, string t)
        {
            if (s == t)
            {
                return true;
            }
            if (s == null || t == null)
            {
                return false;
            }

            return s.OrderBy(_ => _).SequenceEqual(t.OrderBy(_ => _));
        }
    }
}
