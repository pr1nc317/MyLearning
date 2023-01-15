namespace Reorder_List
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

        public static ListNode ReorderList(ListNode A)
        {
            /*
             * 1. Find the middle point using tortoise and hare method.
             * 2. Split the linked list into two halves using found middle point in step 1.
             * 3. Reverse the second half.
             * 4. Do alternate merge of first and second halves.
             */
            var node1 = A;    // slow pointer
            var node2 = A.next;   // fast pointer
            while (node2 != null && node2.next != null)
            {
                node1 = node1.next;
                node2 = node2.next.next;
            }
            node2 = ReverseList(node1.next);
            node1.next = null;
            node1 = A;
            var newNode = new ListNode(0);
            newNode.next = A;
            A = newNode;
            while (node1 != null || node2 != null)
            {
                if (node1 != null)
                {
                    A.next = node1;
                    A = A.next;
                    node1 = node1.next;
                }
                if (node2 != null)
                {
                    A.next = node2;
                    A = A.next;
                    node2 = node2.next;
                }
            }
            return newNode.next;
        }

        public static ListNode ReverseList(ListNode A)
        {
            if (A == null) return null;
            ListNode temp = A.next;
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
            //ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(3); //node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = ReorderList(node1);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
