namespace Remove_Nth_Node_From_List_End
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

        public static ListNode RemoveNthFromEnd(ListNode A, int B)
        {
            // reverse the list, remove the Bth node, reverse the list again
            #region Appraoch 1
            //if (A == null || (A.next == null && B > 0)) return null;
            //if (B == 0) return A;
            //var reversedOnce = ReverseList(A);
            //ListNode ptrToBeDel = reversedOnce;
            //ListNode ptrBeforeToBeDel = new ListNode(0);
            //ptrBeforeToBeDel.next = reversedOnce;
            //if (B == 1)
            //{
            //    reversedOnce = reversedOnce.next;
            //}
            //else
            //{
            //    while (B > 1 && ptrToBeDel != null)
            //    {
            //        B--;
            //        ptrBeforeToBeDel = ptrToBeDel;
            //        ptrToBeDel = ptrToBeDel.next;
            //        if (B > 1 && ptrToBeDel.next == null)
            //        {
            //            ptrBeforeToBeDel.next = null;
            //            return ReverseList(reversedOnce);
            //        }
            //    }
            //    ptrBeforeToBeDel.next = ptrToBeDel.next;
            //    ptrToBeDel.next = null;
            //}
            //var ans = ReverseList(reversedOnce);
            //return ans;
            #endregion

            // get the length of the list, remove length - B + 1 node
            #region Approach 2
            int length = GetLength(A);
            if (length - B + 1 <= 1) return A.next;
            if (length - B + 1 > length) return A;
            var Aptr1 = A;
            var Aptr2 = new ListNode(-1);
            Aptr2.next = Aptr1;
            int nodeToBeDel = length - B + 1;
            while (nodeToBeDel != 1)
            {
                nodeToBeDel--;
                Aptr2 = Aptr1;
                Aptr1 = Aptr1.next;
            }
            Aptr2.next = Aptr1.next;
            Aptr1.next = null;
            return A;
            #endregion
        }

        public static ListNode ReverseList(ListNode A)
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

        public static int GetLength(ListNode A)
        {
            int count = 0;
            while (A != null)
            {
                A = A.next;
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            ListNode node7 = new ListNode(7);
            ListNode node6 = new ListNode(6); node6.next = node7;
            ListNode node5 = new ListNode(5); node5.next = node6;
            ListNode node4 = new ListNode(4); node4.next = node5;
            ListNode node3 = new ListNode(3); node3.next = node4;
            ListNode node2 = new ListNode(2); node2.next = node3;
            ListNode node1 = new ListNode(1); node1.next = node2;
            var ans = RemoveNthFromEnd(node1, 0);
            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
        }
    }
}
