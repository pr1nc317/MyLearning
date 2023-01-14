namespace Remove_Duplicates_From_Sorted_List_II
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
            ListNode orgTemp = org.next;
            if (orgTemp == null)
                return A;
            ListNode ans = new ListNode(0);
            ListNode ansTemp = ans;
            while (org != null && orgTemp != null)
            {
                if (orgTemp.val == org.val)
                {
                    while (orgTemp != null && orgTemp.val == org.val)
                    {
                        orgTemp = orgTemp.next;
                    }
                }
                else
                {
                    var newNode = new ListNode(org.val);
                    ansTemp.next = newNode;
                    ansTemp = newNode;
                }
                org = orgTemp;
                if (orgTemp != null)
                    orgTemp = orgTemp.next;
            }
            if (orgTemp == null && org != null)
            {
                var newNode = new ListNode(org.val);
                ansTemp.next = newNode;
                ansTemp = newNode;
            }
            return ans.next;
        }

        static void Main(string[] args)
        {
            ListNode node7 = new ListNode(6);
            ListNode node6 = new ListNode(6); node6.next = node7;
            ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            DeleteDuplicates(node1);
        }
    }
}
