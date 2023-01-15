namespace Swap_List_Nodes_in_pairs
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

        public static ListNode SwapPairs(ListNode A)
        {
            int B = 2;
            ListNode prev = new ListNode(0);
            ListNode prevPtr = prev;
            while (A != null)
            {
                var org = new ListNode(A.val);
                var orgPtr = org;
                A = A.next;
                if (A != null)
                {
                    var newNode = new ListNode(A.val);
                    orgPtr.next = newNode;
                    orgPtr = newNode;
                    A = A.next;
                }
                var reversed = ReverseList(org);
                prevPtr.next = reversed;
                while (prevPtr.next != null)
                {
                    prevPtr = prevPtr.next;
                }
            }
            return prev.next;
        }

        public static ListNode ReverseList(ListNode A)
        {
            if (A == null) return null;
            var temp = A.next;
            if (temp == null) { return A; }
            A.next = null;
            while (temp != null)
            {
                var curr = temp.next;
                temp.next = A;
                A = temp;
                temp = curr;
            }
            return A;
        }

        static void Main(string[] args)
        {
            ListNode node7 = new ListNode(7);
            ListNode node6 = new ListNode(6); node6.next = node7;
            ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = SwapPairs(node1);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
