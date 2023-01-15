namespace Reverse_Link_List_II
{
    using System;

    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }
        public static ListNode ReverseBetween(ListNode A, int B, int C)
        {
            if (B == C) return A;
            var newNode = new ListNode(0);
            newNode.next = A;
            A = newNode;
            var prev = A;
            int count = 0;
            while (count < B - 1)
            {
                count++;
                prev = prev.next;
            }
            // start reversing
            int countToReverse = C - B + 1;
            count = 1;
            var temp = prev.next;
            var curr = temp.next;
            var prevTemp = temp;
            var lastNodeAfterReverse = temp;
            temp.next = null;
            while (count < countToReverse)
            {
                count++;
                temp = curr;
                curr = temp.next;
                temp.next = prevTemp;
                prevTemp = temp;
            }
            lastNodeAfterReverse.next = curr;
            prev.next = temp;
            return A.next;
        }

        static void Main(string[] args)
        {
            ListNode node9 = new ListNode(9);
            ListNode node8 = new ListNode(8); node8.next = node9;
            ListNode node7 = new ListNode(7); node7.next = node8;
            ListNode node6 = new ListNode(6); node6.next = node7;
            ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = ReverseBetween(node1, 2, 5);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
