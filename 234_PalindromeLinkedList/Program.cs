namespace _234_PalindromeLinkedList
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
        static bool IsPalindrome(ListNode head)
        {
            // step 1 - find the half of the linked list
            var firstHalfEnd = FindHalf(head);

            // step 2 - reverse the second half
            var secondHalfReversed = ReverseHalf(firstHalfEnd.next);

            // step 3 - compare the two halves
            ListNode p1 = head;
            ListNode p2 = secondHalfReversed;
            bool result = true;
            while (result && p2 != null)
            {
                if (p1.val != p2.val) result = false;
                p1 = p1.next;
                p2 = p2.next;
            }

            // step 4 - reverse the second half once again so that original list can be maintained
            firstHalfEnd.next = ReverseHalf(secondHalfReversed);

            return result;
        }

        static ListNode FindHalf(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }

        static ListNode ReverseHalf(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            ListNode temp;
            while (curr != null)
            {
                temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            return prev;
        }

        static void Main(string[] args)
        {
            ListNode third = new ListNode(1);
            ListNode second = new ListNode(2, third);
            ListNode first = new ListNode(2, second);
            ListNode head = new ListNode(1,first);

            Console.WriteLine(IsPalindrome(head));
        }
    }
}
