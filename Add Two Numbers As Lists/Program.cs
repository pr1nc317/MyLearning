namespace Add_Two_Numbers_As_Lists
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

        public static ListNode AddTwoNumbers(ListNode A, ListNode B)
        {
            bool carry = false;
            var ans = new ListNode(0);
            var ansptr = ans;
            while (A != null || B != null)
            {
                int x = 0; int y = 0;
                if (A != null)
                    x = A.val;
                if (B != null)
                    y = B.val;
                int sum = x + y;
                sum += carry ? 1 : 0;
                if (sum >= 10)
                {
                    carry = true;
                    sum %= 10;
                }
                else carry = false;
                var newNode = new ListNode(sum);
                ansptr.next = newNode;
                ansptr = newNode;
                if (A != null) A = A.next; 
                if (B != null) B = B.next;
            }
            if (carry)
                ansptr.next = new ListNode(1);
            return ans.next;
        }

        static void Main(string[] args)
        {
            //ListNode node9 = new ListNode(9);
            //ListNode node8 = new ListNode(8); node8.next = node9;
            //ListNode node7 = new ListNode(7); node7.next = node8;
            //ListNode node6 = new ListNode(6); node6.next = node7;
            //ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); //node4.next = node5;
            ListNode node3 = new ListNode(5); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            
            //ListNode node16 = new ListNode(9);
            //ListNode node15 = new ListNode(8); node15.next = node16;
            //ListNode node14 = new ListNode(7); node14.next = node15;
            ListNode node13 = new ListNode(5); //node13.next = node14;
            ListNode node12 = new ListNode(6); node12.next = node13;
            ListNode node11 = new ListNode(9); node11.next = node12;
            var ans = AddTwoNumbers(node1, node11);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
            Console.WriteLine(4521 + 569);
        }
    }
}
