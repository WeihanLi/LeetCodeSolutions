using LeetCodeSolutions.Array;
using Xunit;

namespace LeetCodeSolutions.UnitTest.Array
{
    public class RemoveDuplicatesTest
    {
        [Theory]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 0, 2, 1, 2, 3 }, new int[] { 0, 2, 1, 3 })]
        public void Solution1Test(int[] nums, int[] expected)
        {
            var result = RemoveDuplicates.Solution1(nums);
            Assert.Equal(expected.Length, result);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], nums[i]);
            }
        }
    }
}