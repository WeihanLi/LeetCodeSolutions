using LeetCodeSolutions.Algorithms;
using Xunit;

namespace LeetCodeSolutions.UnitTest.Algorithms
{
    public class JumpGameTest
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
        [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
        public void Solution1Test(int[] numbers, bool result)
        {
            Assert.Equal(result, JumpGame.Solution1(numbers));
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
        [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
        public void Solution2Test(int[] numbers, bool result)
        {
            Assert.Equal(result, JumpGame.Solution2(numbers));
        }
    }
}
