namespace List_Cycle
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

        public static ListNode DetectCycle(ListNode A)
        {
            var newNode = new ListNode(0);
            newNode.next = A;
            A = newNode;
            var slow = A;
            var fast = A;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    break;
            }
            if (fast == null || fast.next == null) return null;
            var slow2 = A;
            while (slow != slow2)
            {
                slow = slow.next;
                slow2 = slow2.next;
            }
            return slow2;
        }

        static void Main(string[] args)
        {
            //ListNode node4 = new ListNode(4);
            ListNode node9 = new ListNode(9); //node9.next = node4;
            ListNode node8 = new ListNode(8); node8.next = node9;
            ListNode node7 = new ListNode(7); node7.next = node8;
            ListNode node6 = new ListNode(6); node6.next = node7;
            ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(5); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = DetectCycle(node1);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
