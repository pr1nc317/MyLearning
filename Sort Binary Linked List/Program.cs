namespace Sort_Binary_Linked_List
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

        public static ListNode Solve(ListNode A)
        {
            // traverse till the end and count number of 0's and 1's
            // traverse again and keep changing the values of the list in place
            ListNode temp = A;
            int zeros = 0, ones = 0;
            while (temp != null)
            {
                if (temp.val == 0)
                    zeros++;
                else ones++;
                temp = temp.next;
            }
            temp = A;
            while (temp != null && zeros > 0)
            {
                temp.val = 0;
                zeros--;
                temp = temp.next;
            }
            while (temp != null && ones > 0)
            {
                temp.val = 1;
                ones--;
                temp = temp.next;
            }
            return A;
        }

        static void Main(string[] args)
        {
            ListNode list4 = new ListNode(1); list4.next = null;
            ListNode list3 = new ListNode(0); list3.next = list4;
            ListNode list2 = new ListNode(1); list2.next = list3;
            ListNode list1 = new ListNode(0); list1.next = list2;
            Solve(list1);
        }
    }
}
