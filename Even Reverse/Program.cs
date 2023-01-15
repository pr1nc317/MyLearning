namespace Even_Reverse
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
            var APtr = A;
            var oddList = new ListNode(0);
            var oddListPtr = oddList;
            var evenListPtr = new ListNode(0);
            int counter = 1;
            while (APtr != null)
            {
                if (counter % 2 != 0)
                {
                    var newNode = new ListNode(APtr.val);
                    oddListPtr.next = newNode;
                    oddListPtr = newNode;
                }
                else
                {
                    var newNode = new ListNode(APtr.val);
                    newNode.next = evenListPtr;
                    evenListPtr = newNode;
                }
                counter++;
                APtr = APtr.next;
            }
            oddListPtr = oddList.next;
            var ans = new ListNode(0);
            var ansPtr = ans;
            counter = 1;
            while (oddListPtr != null || evenListPtr.next != null)
            {
                if (counter % 2 != 0)
                {
                    var newNode = new ListNode(oddListPtr.val);
                    ansPtr.next = newNode;
                    ansPtr = newNode;
                    oddListPtr = oddListPtr.next;
                }
                else
                {
                    var newNode = new ListNode(evenListPtr.val);
                    ansPtr.next = newNode;
                    ansPtr = newNode;
                    evenListPtr = evenListPtr.next;
                }
                counter++;
            }
            return ans.next;
        }

        static void Main(string[] args)
        {
            //ListNode node7 = new ListNode(7);
            //ListNode node6 = new ListNode(6); node6.next = node7;
            //ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); //node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = Solve(node1);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
