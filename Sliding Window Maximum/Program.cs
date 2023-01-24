namespace Sliding_Window_Maximum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Threading.Tasks.Dataflow;

    internal class Program
    {
        public class DoubleLinkedList
        {
            public int val;
            public DoubleLinkedList prev;
            public DoubleLinkedList next;
            public DoubleLinkedList(int val)
            {
                this.val = val;
            }
        }

        public static DoubleLinkedList head;
        public static DoubleLinkedList tail;

        public static List<int> SlidingMaximum(List<int> A, int B)
        {
            if (B == 1) return A;
            if (B >= A.Count) return new List<int> { A.Max() };
            List<int> ans = new List<int>();
            int i = 0;
            for (i = 0; i < B; i++)
            {
                if (head == null)
                {
                    AddNodeToTail(new DoubleLinkedList(i));
                    continue;
                }
                while (tail != null && A[tail.val] <= A[i])
                    RemoveNodeFromTail();
                AddNodeToTail(new DoubleLinkedList(i));
            }
            ans.Add(A[head.val]);
            for (; i < A.Count; i++)
            {
                if (head == null)
                {
                    AddNodeToTail(new DoubleLinkedList(i));
                    continue;
                }
                while (head != null & head.val <= i - B)
                    RemoveNodeFromHead();
                while (tail != null && A[tail.val] <= A[i])
                    RemoveNodeFromTail();
                AddNodeToTail(new DoubleLinkedList(i));
                ans.Add(A[head.val]);
            }
            return ans;
        }

        public static void AddNodeToTail(DoubleLinkedList node)
        {
            if (tail == null)
            {
                tail = node;
                head = tail;
                return;
            }
            tail.next = node;
            node.prev = tail;
            tail = node;
        }

        public static void RemoveNodeFromTail()
        {
            if (tail == head)
            {
                tail = null;
                head = null; return;
            }
            tail = tail.prev;
            tail.next.prev = null;
            tail.next = null;
        }

        public static void RemoveNodeFromHead()
        {
            if (head == tail)
            {
                tail = null;
                head = null; return;
            }
            head = head.next;
            head.prev.next = null;
            head.prev = null;
        }

        static void Main(string[] args)
        {
            SlidingMaximum(new List<int> { 1, 3, -1, -3, 5, 3, 6, 7 }, 3).ForEach(x => Console.WriteLine(x));
            SlidingMaximum(new List<int> { 251, 286, 420, 491, 506, 34, 716, 829, 615, 53, 807, 837, 750, 650, 181, 140, 543, 944, 210, 113, 551, 379, 818, 817, 227, 525, 257, 735, 932, 172, 410, 935, 351, 347, 521, 168, 482, 885, 612, 352 }, 9).ForEach(x => Console.WriteLine(x));
        }
    }
}
