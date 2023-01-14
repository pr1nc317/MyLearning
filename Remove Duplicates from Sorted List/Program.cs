namespace Remove_Duplicates_from_Sorted_List
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

        public static ListNode DeleteDuplicates(ListNode A)
        {
            ListNode org = A;
            ListNode ans = new ListNode(org.val);
            org = org.next;
            ListNode ansPointer = ans;
            while (org != null)
            {
                if (org.val != ansPointer.val)
                {
                    var newNode = new ListNode(org.val);
                    ansPointer.next = newNode;
                    ansPointer = newNode;
                }
                org = org.next;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            //ListNode node7 = new ListNode(5);
            //ListNode node6 = new ListNode(4); node6.next = node7;
            //ListNode node5 = new ListNode(3); node5.next = node6;
            //ListNode node4 = new ListNode(3); node4.next = node5;
            //ListNode node3 = new ListNode(2); node3.next = node4;
            //ListNode node2 = new ListNode(1); node2.next = node3;
            ListNode node1 = new ListNode(0); //node1.next = node2;
            DeleteDuplicates(node1);
        }
    }
}
