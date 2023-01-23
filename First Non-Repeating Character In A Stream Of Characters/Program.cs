namespace First_Non_Repeating_Character_In_A_Stream_Of_Characters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        public class DoubleLinkedList
        {
            public char val;
            public DoubleLinkedList prev;
            public DoubleLinkedList next;
            public DoubleLinkedList(char val) { this.val = val; }
        }

        public static DoubleLinkedList inDLLHead;
        public static DoubleLinkedList inDLLTail;

        public static string Solve(string A)
        {
            #region Approach 1 - Using Queue and Map
            //StringBuilder ans = new StringBuilder();
            //int[] map = new int[26];
            //Queue<char> queue = new Queue<char>();
            //for (int i = 0; i < A.Length; i++)
            //{
            //    int charIndex = A[i] - 'a';
            //    if (map[charIndex] < 2)
            //    {
            //        if (map[charIndex] == 1)
            //        {
            //            map[charIndex]++;
            //            while (queue.Count > 0 && map[queue.Peek() - 'a'] > 1)
            //                queue.Dequeue();
            //        }
            //        else
            //        {
            //            queue.Enqueue(A[i]);
            //            map[charIndex] = 1;
            //        }
            //    }
            //    if (queue.Count > 0)
            //        ans.Append(queue.Peek());
            //    else ans.Append("#");
            //}
            //return ans.ToString();
            #endregion

            #region Approach 2 - Using Doubly-Linked List as a Queue, list and repeated Array
            List<DoubleLinkedList> list = new List<DoubleLinkedList>(26);
            for (int i = 0; i < 26; i++)
            {
                list.Add(null);
            }
            bool[] rep = new bool[26];
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < A.Length; i++)
            {
                int charIndex = A[i] - 'a';
                if (!rep[charIndex])
                {
                    if (list[charIndex] != null)
                    {
                        RemoveNode(list[charIndex]);
                        rep[charIndex] = true;
                    }
                    else
                    {
                        list[charIndex] = AddNode(new DoubleLinkedList(A[i]));
                    }
                }
                if (inDLLHead == null)
                    ans.Append("#");
                else ans.Append(inDLLHead.val);
            }
            inDLLHead = null;
            inDLLTail = null;
            return ans.ToString();
            #endregion
        }

        private static DoubleLinkedList AddNode(DoubleLinkedList node)
        {
            if (inDLLHead == null)
            {
                inDLLHead = node;
                inDLLTail = inDLLHead;
                return inDLLTail;
            }
            inDLLTail.next = node;
            node.prev = inDLLTail;
            inDLLTail = node;
            return inDLLTail;
        }

        public static void RemoveNode(DoubleLinkedList node)
        {
            if (inDLLHead == null) return;
            if (node.prev == null)
            {
                inDLLHead = node.next;
                if (inDLLHead != null) inDLLHead.prev = null;
                node = null;
                return;
            }
            if (node.next == null)
            {
                inDLLTail = node.prev;
                inDLLTail.next = null;
                node = null;
                return;
            }
            node.prev.next = node.next;
            node.next.prev = node.prev;
            node = null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("abadbc")); // aabbdd
            Console.WriteLine(Solve("abcbbac")); // aaaaac#
            Console.WriteLine(Solve("abccbbac")); // aaaaaa##
            Console.WriteLine(Solve("abcabc")); // aaabc#
        }
    }
}
