namespace SUBTRACT
{
    using System;
    using System.IO;

    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { this.val = x; this.next = null; }
        }

        public static ListNode Subtract(ListNode A)
        {
            // first find the half node, then reverse the second half
            // iterate from head and next of half node found and get the result
            var slow = A;
            var fast = A.next;
            bool odd = false;
            if (fast == null)
            {
                return A;
            }
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast == null)
                odd = true;
            var reversed = ReverseLinkList(slow.next);
            fast = reversed;
            slow.next = fast;
            slow = A;
            while (fast != null)
            {
                slow.val = fast.val - slow.val;
                if (!odd && fast.next == null)
                    break;
                fast = fast.next;
                slow = slow.next;
            }
            fast = ReverseLinkList(reversed);
            slow.next = fast;
            return A;
        }

        private static ListNode ReverseLinkList(ListNode A)
        {
            var temp = A.next;
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
            //ListNode node9 = new ListNode(9);
            //ListNode node8 = new ListNode(8); node8.next = node9;
            //ListNode node7 = new ListNode(7); node7.next = node8;
            //ListNode node6 = new ListNode(6); node6.next = node7;
            //ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); //node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = Subtract(node1);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
