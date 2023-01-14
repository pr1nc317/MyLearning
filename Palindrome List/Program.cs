namespace Palindrome_List
{
    using System;
    using System.Transactions;

    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }

        public static int LPalin(ListNode A)
        {
            ListNode slow = A;
            ListNode fast = A.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next; fast = fast.next.next;
            }
            fast = slow.next;
            if (fast == null) // input list only has 1 node, return 1
                return 1;
            // Reversing the toReverse list
            ListNode reversed = new ListNode(fast.val);
            fast = fast.next;
            while (fast != null)
            {
                ListNode curr = new ListNode(fast.val);
                curr.next = reversed;
                reversed = curr;
                fast = fast.next;
            }
            slow = A;
            while (reversed != null)
            {
                if (slow.val != reversed.val)
                    return 0;
                slow = slow.next;
                reversed = reversed.next;
            }
            return 1;
        }

        static void Main(string[] args)
        {
            //ListNode node6 = new ListNode(5);
            //ListNode node5 = new ListNode(4); //node5.next = node6;
            //ListNode node4 = new ListNode(2); node4.next = node5;
            //ListNode node3 = new ListNode(3); node3.next = node4;
            //ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(4); //node1.next = node2;
            Console.WriteLine(LPalin(node1));
        }
    }
}
