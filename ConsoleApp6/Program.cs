using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<List<int>>()
            {
                new List<int>() {1,2,3,4 },
                new List<int>() { 5,6,7,8 },
                new List<int>() {9,10,11,12 },
                new List<int>() {13,14,15,16 }
            };

            var b = new int[] { 1, 5, 2, 1, 4, 0 };
            //var b = new int[] { 1,0,1 };
            FindIntersect(b);
        }

        private static int FindIntersect(int[] input)
        {
            var intersect = new List<Tuple<int, int>>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i > j)
                    {
                        if (j - i > input[i] + input[j])
                        {
                            intersect.Add(new Tuple<int, int>(i, j));
                        }
                    }
                    else if (i < j)
                    {
                        if (i - j > input[i] + input[j])
                        {
                            intersect.Add(new Tuple<int, int>(i, j));
                        }
                    }
                }
            }
            var a = intersect;
            return 0;
        }


        static void matrixRotation(List<List<int>> matrix, int r)
        {


        }


        public static long getNumber2(List<int> list)
        {
            int value = 0;
            for (int i = 0; i < list.Count; i++)
            {
                value |= (list[i] << list.Count - i - 1);
            }
            return value;
        }

        public static long getNumber(List<int> binary)
        {
            long result = 0;
            int pow = binary.Count - 1;
            foreach (var temp in binary)
            {
                result += Convert.ToInt64(Math.Pow(temp == 1 ? 2 : 0, pow));
                pow--;
            }
            return result;            
        }
        public static long getNumber1(List<int> binary)
        {
            StringBuilder st = new StringBuilder();
            foreach (var temp in binary)
            {
                st.Append(temp);
            }
            return Convert.ToInt64(st.ToString(), 2);
        }
    }
    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    class SinglyLinkedListPrintHelepr
    {
        public static void PrintList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }
    }
}
