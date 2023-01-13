namespace Sort_List
{
    using System;
    using System.Data;

    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }

        // MERGE SORT
        public static ListNode SortList(ListNode A)
        {
            if (A.next == null)
            {
                return A;
            }
            ListNode leftNode = GetMid(A);
            ListNode rightNode = leftNode.next;
            leftNode.next = null;
            ListNode left = SortList(A);
            ListNode right = SortList(rightNode);
            ListNode ans = Merge(left, right);
            return ans;
        }

        public static ListNode Merge(ListNode A, ListNode B)
        {
            ListNode merged = new ListNode(0);
            ListNode tail = merged;
            while (A != null && B != null)
            {
                if (A.val <= B.val)
                {
                    tail.next = A;
                    A = A.next;
                }
                else
                {
                    tail.next = B;
                    B = B.next;
                }
                tail = tail.next;
            }
            while (A != null)
            {
                tail.next = A;
                A = A.next;
                tail = tail.next;
            }
            while (B != null)
            {
                tail.next = B;
                B = B.next;
                tail = tail.next;
            }
            return merged.next;
        }

        public static ListNode GetMid(ListNode A)
        {
            ListNode slow = A; ListNode fast = A.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
