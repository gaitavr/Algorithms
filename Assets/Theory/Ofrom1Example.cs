using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ofrom1Example : MonoBehaviour
{
    private int[] _numbers = {1, 5, 2, 6, 7, 2, 5,2,6,7};

    private bool IsNumberEven(int index)
    {
        return _numbers[index] % 2 == 0;
    }

    private void OtherExamples()
    {
        Mathf.Approximately(1.0f, 0.999f);
        var second = _numbers[2];
        var dictionary = new Dictionary<int, string>()
        {
            [1] = "Adam"
        };
        dictionary[1] = "Alex";
        var stack = new Stack<string>();
        stack.Push("Plane");
        var queue = new Queue<int>();
        queue.Enqueue(2);
    }
}
