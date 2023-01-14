namespace Merge_Two_Sorted_Lists
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

        public static ListNode MergeTwoLists(ListNode A, ListNode B)
        {
            ListNode aPointer = A;
            ListNode bPointer = B;
            ListNode ans = new ListNode(-1);
            ListNode ansPointer = ans;
            while (aPointer != null && bPointer != null) 
            {
                if (aPointer.val < bPointer.val)
                {
                    var newNode = new ListNode(aPointer.val);
                    ansPointer.next = newNode;
                    ansPointer = newNode;
                    aPointer = aPointer.next;
                }
                else
                {
                    var newNode = new ListNode(bPointer.val);
                    ansPointer.next = newNode;
                    ansPointer = newNode;
                    bPointer = bPointer.next;
                }
            }
            while (aPointer != null)
            {
                var newNode = new ListNode(aPointer.val);
                ansPointer.next = newNode;
                ansPointer = newNode;
                aPointer = aPointer.next;
            }
            while (bPointer != null)
            {
                var newNode = new ListNode(bPointer.val);
                ansPointer.next = newNode;
                ansPointer = newNode;
                bPointer = bPointer.next;
            }
            return ans.next;
        }

        static void Main(string[] args)
        {
            //ListNode node7 = new ListNode(66);
            //ListNode node6 = new ListNode(16); node6.next = node7;
            //ListNode node5 = new ListNode(15); node5.next = node6;
            //ListNode node4 = new ListNode(14); node4.next = node5;
            //ListNode node3 = new ListNode(3); node3.next = node4;
            //ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); //node1.next = node2;

            //ListNode node14 = new ListNode(40);
            //ListNode node13 = new ListNode(22); node13.next = node14;
            //ListNode node12 = new ListNode(15); node12.next = node13;
            //ListNode node11 = new ListNode(12); node11.next = node12;
            //ListNode node10 = new ListNode(9); node10.next = node11;
            //ListNode node9 = new ListNode(8); node9.next = node10;
            ListNode node8 = new ListNode(5); //node8.next = node9;
            MergeTwoLists(node1, node8);
        }
    }
}
