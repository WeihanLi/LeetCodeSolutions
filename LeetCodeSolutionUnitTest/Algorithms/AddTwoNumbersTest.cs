using System;
using System.Linq;
using LeetCodeSolutions.Algorithms;
using Xunit;

namespace LeetCodeSolutions.UnitTest.Algorithms
{
    public class AddTwoNumbersTest
    {
        [Theory]
        [InlineData(321, 123)]
        [InlineData(342, 465)]
        [InlineData(5, 5)]
        public void Sln1Test(int num1, int num2)
        {
            var node1 = ListNode.New(num1.ToString().Select(c => Convert.ToInt32(char.GetNumericValue(c))).Reverse().ToArray());
            var node2 = ListNode.New(num2.ToString().Select(c => Convert.ToInt32(char.GetNumericValue(c))).Reverse().ToArray());

            Assert.Equal(num1 + num2, Convert.ToInt32(AddTwoNumbers.Solution1(node1, node2).ToString()));
        }
    }
}
