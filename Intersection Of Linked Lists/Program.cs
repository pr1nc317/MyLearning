namespace Intersection_Of_Linked_Lists
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

        public ListNode getIntersectionNode(ListNode A, ListNode B)
        {
            // return null if any of the input is null
            if (A== null || B == null) return null;

            // get the longer and shorter linked list
            var longer = GetSize(A) > GetSize(B) ? A : B;
            var shorter = GetSize(B) < GetSize(A) ? B : A;

            // iterate over the longer list and get to the point where length of longer and shorter lists becomes similar
            longer = SkipKElements(longer, Math.Abs(GetSize(A) - GetSize(B)));
            while (longer != shorter)
            {
                longer = longer.next; shorter = shorter.next;
            }
            return longer;
        }

        public static int GetSize(ListNode list)
        {
            int size = 0;
            while (list != null)
            {
                list = list.next;
                size++;
            }
            return size;
        }

        public static ListNode SkipKElements(ListNode list, int diff)
        {
            ListNode temp = list;
            while (diff > 0)
            {
                diff--;
                temp = temp.next;
            }
            return temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
