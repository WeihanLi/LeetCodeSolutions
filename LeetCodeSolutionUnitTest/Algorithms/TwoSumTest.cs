using LeetCodeSolutions.Algorithms;
using Xunit;

namespace LeetCodeSolutions.UnitTest.Explor
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void Soltion1Test(int[] nums, int target, int[] expected)
        {
            var result = TwoSum.Solution1(nums, target);
            Assert.Equal(expected[0], result[0]);
            Assert.Equal(expected[1], result[1]);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void Soltion2Test(int[] nums, int target, int[] expected)
        {
            var result = TwoSum.Solution2(nums, target);
            Assert.Equal(expected[0], result[0]);
            Assert.Equal(expected[1], result[1]);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void Soltion3Test(int[] nums, int target, int[] expected)
        {
            var result = TwoSum.Solution3(nums, target);
            Assert.Equal(expected[0], result[0]);
            Assert.Equal(expected[1], result[1]);
        }
    }
}
