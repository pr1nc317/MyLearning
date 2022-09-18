namespace _876_MiddleoftheLinkedList
{
    using System;

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {
        static ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head; ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast.next == null) return slow;
            else return slow.next;
        }

        static void Main(string[] args)
        {
            ListNode sixth = new ListNode(6);
            ListNode fifth = new ListNode(5, sixth);
            ListNode fourth = new ListNode(4, fifth);
            ListNode third = new ListNode(3, fourth);
            ListNode second = new ListNode(2, third);
            ListNode head = new ListNode(1, second);
            var ans = MiddleNode(head);
            while (ans.next != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
            Console.WriteLine(ans.val);
        }
    }
}
