namespace Rotate_List
{
    using System;
    using System.Security.Cryptography;

    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }

        public static ListNode RotateRight(ListNode A, int B)
        {
            int len = GetLength(A);
            if (len == 1 || B % len == 0) return A;
            int toRotate = len - (B % len);
            var APtr = A;
            while (toRotate > 1)
            {
                APtr = APtr.next;
                toRotate--;
            }
            var ans = APtr.next;
            APtr.next = null;
            APtr = ans;
            while (APtr.next != null)
            {
                APtr = APtr.next;
            }
            APtr.next = A;
            return ans;
        }

        public static int GetLength(ListNode A)
        {
            int size = 0;
            while (A != null)
            {
                size++;
                A = A.next;
            }
            return size;
        }

        static void Main(string[] args)
        {
            //ListNode node7 = new ListNode(7);
            ListNode node6 = new ListNode(6); //node6.next = node7;
            ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = RotateRight(node1, 12); // (node1, 5) = 3 4 5 6 7 1 2
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
