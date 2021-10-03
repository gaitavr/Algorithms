using System.Collections.Generic;
using UnityEngine;

namespace _4._QueueWithStacks
{
    public class QueueWithStacks : MonoBehaviour
    {
        private void Start()
        {
            var queue = new CustomQueue<int>();
            queue.Enqueue(3);
            var t = queue.Peek();
            Debug.Log(t == 3);
            t = queue.Dequeue();
            Debug.Log(t == 3);
            t = queue.Dequeue();
            Debug.Log(t == 0);
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(8);
            t = queue.Dequeue();
            Debug.Log(t == 2);
            t = queue.Peek();
            Debug.Log(t == 4);
        }
    }
}