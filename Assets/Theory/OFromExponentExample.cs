using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class OFromExponentExample : MonoBehaviour
{
    private void Start()
    {
        PowerSet("");// ...
        PowerSet("A");// , A...
        PowerSet("AB");// , A, B, AB...
        PowerSet("ABC");// , A, B, AB, C, AC, BC, ABC...
    }
    
    private List<string> PowerSet(string options)
    {
        var n = options.Length;
        var powerSetCount = 1 << n;
        var result = new List<string>();

        for (var setMask = 0; setMask < powerSetCount; setMask++)
        {
            var s = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                if ((setMask & (1 << i)) > 0)
                {
                    s.Append(options[i]);
                }
            }
            result.Add(s.ToString());
        }

        return result;
    }
    
    private int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}