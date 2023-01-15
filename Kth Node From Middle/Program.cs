namespace Kth_Node_From_Middle
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

        public static int Solve(ListNode A, int B)
        {
            // calculate mid for even and odd cases
            var slowPtr = A; var fastPtr = A.next;
            int count = 1;
            if (fastPtr == null) return -1;
            while (fastPtr != null && fastPtr.next != null)
            {
                count++;
                slowPtr = slowPtr.next;
                fastPtr = fastPtr.next.next;
            }
            // odd case
            if (fastPtr == null)
            {
                // slow pointer is already at mid, so do nothing
            }
            else // even case -- slow pointer is 1 position behind the mid, so do count++
                count++;
            if (B >= count) return -1;
            else
            {
                int eleToFind = count - B;
                return FindElement(A, eleToFind);
            }
        }

        public static int FindElement(ListNode A, int B)
        {
            int count = 1;
            while (count != B)
            {
                count++;
                A = A.next;
            }
            return A.val;
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
            Console.WriteLine(Solve(node1, 0));
            //while (ans != null)
            //{
            //    Console.WriteLine(ans.val);
            //    ans = ans.next;
            //}
        }
    }
}
