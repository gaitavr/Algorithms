using System.Collections.Generic;
using UnityEngine;

public class PermutationsExample : MonoBehaviour
{
    private void Start()
    {
        PrintResult(
            Permute(new[] {1, 2, 3, 6, 3})
        );
    }

    private IList<IList<int>> Permute(int[] nums)
    {
        var list = new List<IList<int>>();
        return PermuteRecursive(nums, 0, nums.Length - 1, list);
    }

    private IList<IList<int>> PermuteRecursive(int[] nums, int start, int end, 
        IList<IList<int>> list)
    {
        if (start == end)
        {
            // We have one of our possible n! solutions,
            // add it to the list.
            list.Add(new List<int>(nums));
        }
        else
        {
            for (var i = start; i <= end; i++)
            {
                Swap(ref nums[start], ref nums[i]);
                PermuteRecursive(nums, start + 1, end, list);
                Swap(ref nums[start], ref nums[i]);
            }
        }

        return list;
    }

    private void Swap(ref int a, ref int b)
    {
        var temp = a;
        a = b;
        b = temp;
    }

    private void PrintResult(IList<IList<int>> lists)
    {
        Debug.Log("[");
        foreach (var list in lists)
        {
            Debug.Log($"    [{string.Join(",", list)}]");
        }
        Debug.Log("]");
    }
}