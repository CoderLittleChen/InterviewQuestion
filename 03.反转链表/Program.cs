using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.反转链表
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;

            Node<int> reverseHead = ReverseList(node1);
            while (reverseHead!=null)
            {
                Console.WriteLine(reverseHead.Data);
                reverseHead = reverseHead.Next;
            }

            Console.ReadKey();

        }


        /// <summary>
        /// 返回链表反转后的头节点
        /// 注意这里通过泛型返回  需要在其方法体后加上泛型标记 <T>
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node<T> ReverseList<T>(Node<T> head)
        {
            //定义返回后的头节点
            Node<T> reverseHead = null;
            //定义当前节点
            Node<T> currentNode = head;
            //定义上一节点
            Node<T> prevNode = null;

            //循环条件 怎么确定？
            while (currentNode != null)
            {
                //拿到下一节点
                Node<T> nextNode = currentNode.Next;
                if (nextNode == null)
                {
                    reverseHead = currentNode;
                }

                currentNode.Next = prevNode;

                prevNode = currentNode;

                currentNode = nextNode;
            }

            return reverseHead;
        }


    }
}
