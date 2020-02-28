using System;
using System.Collections.Generic;
using System.Linq;
using WeihanLi.Extensions;

namespace LeetCodeSolutions.Algorithms
{
    public class ListNode
    {
        public static ListNode New(string str) =>
            New(str.Select(c => Convert.ToInt32(char.GetNumericValue(c))).Reverse().ToArray());

        public static ListNode New(params int[] values)
        {
            if (values != null && values.Length > 0)
            {
                var node = new ListNode(values[values.Length - 1]);
                for (var i = values.Length - 2; i >= 0; i--)
                {
                    node = new ListNode(values[i])
                    {
                        next = node,
                    };
                }
                return node;
            }
            return null;
        }

        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }

        public override string ToString()
        {
            var stack = new Stack<int>();
            var nextNode = this;
            while (nextNode != null)
            {
                stack.Push(nextNode.val);
                nextNode = nextNode.next;
            }

            return stack.StringJoin("");
        }
    }

    /// <summary>
    /// AddTwoNumbers
    /// https://leetcode-cn.com/problems/add-two-numbers/
    /// </summary>
    public class AddTwoNumbers
    {
        public static ListNode Solution1(ListNode node1, ListNode node2)
        {
            var nums = new List<int>();
            var increment = 0;
            while (node1 != null || node2 != null)
            {
                //
                var sum = (node1?.val ?? 0) + (node2?.val ?? 0) + increment;
                if (sum >= 10)
                {
                    increment = sum / 10;
                }
                else
                {
                    increment = 0;
                }

                var val = sum % 10;
                nums.Add(val);

                node1 = node1?.next;
                node2 = node2?.next;
            }

            if (increment > 0)
            {
                nums.Add(increment);
            }
            return ListNode.New(nums.ToArray());
        }
    }
}
