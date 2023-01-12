namespace Reverse_Linked_List
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

        public ListNode ReverseList(ListNode A)
        {
            ListNode temp = A.next;
            A.next = null;
            while (temp.next != null)
            {
                ListNode curr = temp.next;
                temp.next = A;
                A = temp;
                temp= curr;
            }
            temp.next = A;
            return temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
