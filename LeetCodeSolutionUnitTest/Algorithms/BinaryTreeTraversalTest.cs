using System.Collections.Generic;
using System.Linq;
using LeetCodeSolutions.Algorithms;
using Xunit;

namespace LeetCodeSolutions.UnitTest.Algorithms
{
    public class BinaryTreeTraversalTest
    {
        [Fact]
        public void InOrderSolution1Test()
        {
            var tree = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            IReadOnlyList<int> expectedResult = new int[] { 1, 3, 2 };
            var result = BinaryTreeInOrderTraversal.Solution1(tree);
            Assert.Equal(expectedResult.Count, result.Count);
            Assert.True(expectedResult.SequenceEqual(result));
        }

        [Fact]
        public void InOrderSolution2Test()
        {
            var tree = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            IReadOnlyList<int> expectedResult = new int[] { 1, 3, 2 };
            var result = BinaryTreeInOrderTraversal.Solution2(tree);
            Assert.Equal(expectedResult.Count, result.Count);
            Assert.True(expectedResult.SequenceEqual(result));
        }

        [Fact]
        public void PreOrderSolution1Test()
        {
            var tree = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            IReadOnlyList<int> expectedResult = new int[] { 1, 2, 3 };
            var result = BinaryTreePreOrderTraversal.Solution1(tree);
            Assert.Equal(expectedResult.Count, result.Count);
            Assert.True(expectedResult.SequenceEqual(result));
        }

        [Fact]
        public void PreOrderSolution2Test()
        {
            var tree = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            IReadOnlyList<int> expectedResult = new int[] { 1, 2, 3 };
            var result = BinaryTreePreOrderTraversal.Solution2(tree);
            Assert.Equal(expectedResult.Count, result.Count);
            Assert.True(expectedResult.SequenceEqual(result));
        }

        [Fact]
        public void PostOrderSolution1Test()
        {
            var tree = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            IReadOnlyList<int> expectedResult = new int[] { 3, 2, 1 };
            var result = BinaryTreePostOrderTraversal.Solution1(tree);
            Assert.Equal(expectedResult.Count, result.Count);
            Assert.True(expectedResult.SequenceEqual(result));
        }

        [Fact]
        public void PostOrderSolution2Test()
        {
            var tree = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            IReadOnlyList<int> expectedResult = new int[] { 3, 2, 1 };
            var result = BinaryTreePostOrderTraversal.Solution2(tree);
            Assert.Equal(expectedResult.Count, result.Count);
            Assert.True(expectedResult.SequenceEqual(result));
        }
    }
}
