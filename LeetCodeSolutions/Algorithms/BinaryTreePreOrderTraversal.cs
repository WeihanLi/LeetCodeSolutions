using System.Collections.Generic;

namespace LeetCodeSolutions.Algorithms
{
    public class BinaryTreePreOrderTraversal
    {
        public static IReadOnlyList<int> Solution1(TreeNode tree)
        {
            var list = new List<int>();
            Traversal(tree);
            return list;

            void Traversal(TreeNode treeNode)
            {
                if (treeNode != null)
                {
                    list.Add(treeNode.val);

                    if (treeNode.left != null)
                    {
                        Traversal(treeNode.left);
                    }
                    if (treeNode.right != null)
                    {
                        Traversal(treeNode.right);
                    }
                }
            }
        }

        public static IReadOnlyList<int> Solution2(TreeNode root)
        {
            var list = new List<int>();
            var stack = new Stack<TreeNode>();
            var curr = root;
            while (curr != null || stack.Count > 0)
            {
                while (curr != null)
                {
                    list.Add(curr.val);

                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Pop();
                curr = curr.right;
            }
            return list;
        }
    }
}
