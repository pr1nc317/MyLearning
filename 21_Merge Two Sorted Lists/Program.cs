namespace _21_Merge_Two_Sorted_Lists
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
        static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            var tempList = new ListNode();
            var ans = tempList;
            int val1 = 0; int val2 = 0;
            while (list1 != null && list2 != null)
            {
                val1 = list1.val;
                val2 = list2.val;
                if (val1 <= val2)
                {
                    tempList.val = val1;
                    list1 = list1.next;
                }
                else
                {
                    tempList.val = val2;
                    list2 = list2.next;
                }
                tempList.next = new ListNode();
                tempList = tempList.next;
            }
            if (list1 == null)
            {
                while (list2.next != null)
                {
                    tempList.val = list2.val;
                    tempList.next = new ListNode();
                    tempList = tempList.next;
                    list2 = list2.next;
                }
                tempList.val = list2.val;
                tempList.next = null;
            }
            else if (list2 == null)
            {
                while (list1.next != null)
                {
                    tempList.val = list1.val;
                    tempList.next = new ListNode();
                    tempList = tempList.next;
                    list1 = list1.next;
                }
                tempList.val = list1.val;
                tempList.next = null;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            ListNode list2_5 = new ListNode(6);
            ListNode list2_4 = new ListNode(6, list2_5);
            ListNode list2_3 = new ListNode(4, list2_4);
            ListNode list2_2 = new ListNode(3, list2_3);
            ListNode list2_1 = new ListNode(1, list2_2);

            ListNode list1_3 = new ListNode(4);
            ListNode list1_2 = new ListNode(2, list1_3);
            ListNode list1_1 = new ListNode(1, list1_2);
            MergeTwoLists(list1_1, list2_1);
        }
    }
}
