using UnityEngine;

public class OFromNExample : MonoBehaviour
{
    private int[] _numbers = {1,2,2,5,6,7};

    private int CalculateSum()
    {
        var result = 0;
        for (int i = 0; i < _numbers.Length; i++)
        {
            result += _numbers[i];
        }
        return result;
    }

    private int FindMaxElement()
    {
        var max = int.MinValue;
        foreach (var n in _numbers)
        {
            if (n > max)
                max = n;
        }
        return max;
    }
}