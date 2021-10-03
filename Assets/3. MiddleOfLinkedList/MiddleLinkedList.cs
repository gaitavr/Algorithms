using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace _3._MiddleOfLinkedList
{
    public class MiddleLinkedList : MonoBehaviour
    {
        private readonly LinkedList<int> _source = new LinkedList<int>();

        private void Start()
        {
            FillList(10);
            var middle = GetMiddle2();
            Debug.Log($"Middle is: {middle}");
        }

        private void FillList(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _source.AddLast(i);
            }
        }

        private int GetMiddle1()
        {
            var newList = _source.ToList();
            return newList[newList.Count / 2];
        }

        private int GetMiddle2()
        {
            LinkedListNode<int> slow = _source.First;
            LinkedListNode<int> fast = _source.First;
            while (fast?.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow.Value;
        }
    }
}