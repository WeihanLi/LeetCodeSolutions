using System;
using System.Collections.Generic;

namespace LeetCodeSolutions.Algorithms
{
    public class BinaryTreeInOrderTraversal
    {
        public static IReadOnlyList<int> Solution1(TreeNode tree)
        {
            var list = new List<int>();
            InOrderTraversal(tree);
            return list;

            void InOrderTraversal(TreeNode treeNode)
            {
                if (treeNode != null)
                {
                    if (treeNode.left != null)
                    {
                        InOrderTraversal(treeNode.left);
                    }

                    list.Add(treeNode.val);

                    if (treeNode.right != null)
                    {
                        InOrderTraversal(treeNode.right);
                    }
                }
            }
        }

        public static IReadOnlyList<int> Solution2(TreeNode root)
        {
            if (root is null)
            {
                return Array.Empty<int>();
            }

            var res = new List<int>();
            var stack = new Stack<TreeNode>();
            var curr = root;
            while (curr != null || stack.Count > 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                res.Add(curr.val);
                curr = curr.right;
            }
            return res;
        }
    }

    public class TreeNode
    {
        public TreeNode(int value)
        {
            val = value;
        }

        public TreeNode left { get; set; }

        public TreeNode right { get; set; }

        public int val { get; }
    }
}
