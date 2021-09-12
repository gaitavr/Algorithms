using System.Collections.Generic;
using UnityEngine;

public class OFromNpowExample : MonoBehaviour
{
    private void BubbleSort(int[] source)
    {
        for (var i = 0; i < source.Length; i++)
        {
            for (var j = 0; j < source.Length - 1; j++)
            {
                if (source[j] > source[j + 1])
                {
                    var temp = source[j + 1];
                    source[j + 1] = source[j];
                    source[j] = temp;
                }
            }
        }
    }
    
    //6x + y - 12z = 42
    private Solution[] SolveEquation(int n)
    {
        var solutions = new List<Solution>();
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                for (int z = 0; z < n; z++)
                {
                    if(6 * x + y - 12 * z == 42)
                        solutions.Add(new Solution(x, y, z));
                }
            }
        }
        return solutions.ToArray();
    }
    
    private struct Solution
    {
        public int X; public int Y; public int Z;

        public Solution(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }
    }
}