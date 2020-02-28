using LeetCodeSolutions.Algorithms;
using Xunit;

namespace LeetCodeSolutions.UnitTest.Algorithms
{
    public class ValidAnagramTest
    {
        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        public void Sln1Test(string s, string t, bool valid)
        {
            Assert.Equal(valid, ValidAnagram.Solution1(s, t));
        }
    }
}
