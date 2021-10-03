using System.Collections.Generic;
using System.Text;

namespace _4._QueueWithStacks
{
    public class CustomQueue<T>
    {
        private readonly Stack<T> _stack1 = new Stack<T>();
        private readonly Stack<T> _stack2 = new Stack<T>();

        public int Count => _stack2.Count;
        public bool IsEmpty => Count == 0;

        public void Enqueue(T element)
        {
            _stack1.Push(element);
        }

        public T Dequeue()
        {
            FillStack2();
            if (IsEmpty)
                return default;
            return _stack2.Pop();
        }

        public T Peek()
        {
            FillStack2();
            if (IsEmpty)
                return default;
            return _stack2.Peek();
        }

        private void FillStack2()
        {
            while (_stack1.Count > 0)
            {
                _stack2.Push(_stack1.Pop());
            }
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            foreach (var element in _stack2)
            {
                strBuilder.Append(element);
                strBuilder.Append(';');
            }

            return strBuilder.ToString();
        }
    }
}