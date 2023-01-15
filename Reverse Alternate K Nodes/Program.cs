namespace Reverse_Alternate_K_Nodes
{
    using System;
    using System.Xml.Linq;

    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }

        public static ListNode Solve(ListNode A, int B)
        {
            if (B == 1) return A;
            ListNode prev = new ListNode(0);
            ListNode prevPtr = prev;
            ListNode APtr = A;
            ListNode next = A;
            int counter = 1;
            int copyB;
            while (next != null)
            {
                copyB = B;
                ListNode toReverse = new ListNode(0);
                var toReversePtr = toReverse;
                while (copyB > 0)
                {
                    if (counter % 2 != 0)
                    {
                        var newNode = new ListNode(APtr.val);
                        toReversePtr.next = newNode;
                        toReversePtr = newNode;
                    }
                    else
                    {
                        var newNode = new ListNode(APtr.val);
                        prevPtr.next = newNode;
                        prevPtr = newNode;
                    }
                    copyB--;
                    APtr = APtr.next;
                }
                next = APtr;
                if (counter % 2 == 0)
                {
                    counter++;
                    continue;
                }
                var reversed = Reverse(toReverse.next);
                prevPtr.next = reversed;
                while (prevPtr.next != null)
                    prevPtr = prevPtr.next;
                counter++;
            }
            return prev.next;
        }

        private static ListNode Reverse(ListNode A)
        {
            if (A == null) return null;
            var temp = A.next;
            if (temp == null) { return A; }
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
            ListNode node9 = new ListNode(9);
            ListNode node8 = new ListNode(8); node8.next = node9;
            ListNode node7 = new ListNode(7); node7.next = node8;
            ListNode node6 = new ListNode(6); node6.next = node7;
            ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = Solve(node1, 3); // (node1, 5) = 3 4 5 6 7 1 2
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
