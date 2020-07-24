using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeSolutions.Algorithms
{
    public class BinaryTreePostOrderTraversal
    {
        public static IReadOnlyList<int> Solution1(TreeNode root)
        {
            var list = new List<int>();
            Traversal(root);
            return list;

            void Traversal(TreeNode treeNode)
            {
                if (treeNode != null)
                {
                    if (treeNode.left != null)
                    {
                        Traversal(treeNode.left);
                    }
                    if (treeNode.right != null)
                    {
                        Traversal(treeNode.right);
                    }

                    list.Add(treeNode.val);
                }
            }
        }

        public static IReadOnlyList<int> Solution2(TreeNode root)
        {
            if (root is null)
            {
                return Array.Empty<int>();
            }

            var list = new List<int>();
            var stack = new Stack();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var t = (TreeNode)stack.Pop();
                if (t != null)
                {
                    stack.Push(t);
                    stack.Push(null);//一个空来表示这个是已经康过的父节点
                    if (t.right != null) stack.Push(t.right);
                    if (t.left != null) stack.Push(t.left);
                }
                else
                {
                    var val = ((TreeNode)stack.Pop()).val;
                    list.Add(val);
                }
            }

            return list;
        }
    }
}
