namespace Partition_List
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }

        public static ListNode Partition(ListNode A, int B)
        {
            #region Approach 1 - Using List
            //List<int> list = new List<int>();
            //ListNode temp = A;
            //while (temp != null)
            //{
            //    list.Add(temp.val);
            //    temp = temp.next;
            //}
            //temp = A;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] < B)
            //    {
            //        temp.val = list[i];
            //        temp = temp.next;
            //    }
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] >= B)
            //    {
            //        temp.val = list[i];
            //        temp = temp.next;
            //    }
            //}
            //return A;
            #endregion

            #region Approach 2 - Using Linked List
            ListNode smaller = new ListNode(0);
            ListNode smallerTemp = smaller;
            ListNode greater = new ListNode(0);
            ListNode greaterTemp = greater;
            var temp = A;
            while (temp != null)
            {
                if (temp.val < B)
                {
                    var node = new ListNode(temp.val);
                    smaller.next = node;
                    smaller = node;
                }
                else
                {
                    var node = new ListNode(temp.val);
                    greater.next = node;
                    greater = node;
                }
                temp = temp.next;
            }
            if (smaller.val != 0)
                smaller.next = greaterTemp.next;
            else return greaterTemp.next;
            return smallerTemp.next;
            #endregion
        }

        static void Main(string[] args)
        {
            //ListNode node6 = new ListNode(2);
            //ListNode node5 = new ListNode(5); node5.next = node6;
            //ListNode node4 = new ListNode(2); node4.next = node5;
            //ListNode node3 = new ListNode(3); node3.next = node4;
            //ListNode node2 = new ListNode(4); node2.next = node3;
            //ListNode node1 = new ListNode(1); node1.next = node2;
            //Partition(node1, 3);


            ListNode node7 = new ListNode(1);
            Partition(node7, 1);

            //ListNode node5 = new ListNode(3); 
            //ListNode node4 = new ListNode(1); node4.next = node5;
            //ListNode node3 = new ListNode(3); node3.next = node4;
            //ListNode node2 = new ListNode(2); node2.next = node3;
            //ListNode node1 = new ListNode(1); node1.next = node2;
            //Partition(node1, 2);
        }
    }
}
