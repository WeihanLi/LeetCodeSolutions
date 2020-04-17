using LeetCodeSolutions.Algorithms;
using Xunit;

namespace LeetCodeSolutions.UnitTest.Algorithms
{
    public class PalindromeNumberTest
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(-121, false)]
        [InlineData(12, false)]
        [InlineData(121, true)]
        public void Solution1Test(int num, bool result)
        {
            Assert.Equal(result, PalindromeNumber.Solution1(num));
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        [InlineData(12, false)]
        [InlineData(121, true)]
        [InlineData(500, false)]
        [InlineData(88888, true)]
        [InlineData(888888, true)]
        public void Solution2Test(int num, bool result)
        {
            Assert.Equal(result, PalindromeNumber.Solution2(num));
        }
    }
}
