namespace Insertion_Sort_List
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

        public static ListNode sorted;

        public static ListNode InsertionSortList(ListNode A)
        {
            sorted = null;
            ListNode curr = A;
            while (curr != null)
            {
                ListNode next = curr.next;
                SortedInsert(curr);
                curr = next;
            }
            return sorted;
        }

        public static void SortedInsert(ListNode newNode)
        {
            if (sorted == null || sorted.val >= newNode.val)
            {
                newNode.next = sorted;
                sorted = newNode;
            }
            else
            {
                ListNode curr = sorted;
                while (curr.next != null && curr.next.val < newNode.val)
                {
                    curr = curr.next;
                }
                newNode.next = curr.next;
                curr.next = newNode;
            }
        }

        static void Main(string[] args)
        {
            ListNode node6 = new ListNode(5);
            ListNode node5 = new ListNode(20); node5.next = node6;
            ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(30); node2.next = node3;
            ListNode node1 = new ListNode(13); node1.next = node2;
            InsertionSortList(node1);
        }
    }
}
