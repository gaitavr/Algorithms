using System;
using UnityEngine;

public class OFromLogNExample : MonoBehaviour
{
    private string[] _books =
    {
        "The Pilgrim’s Progress",
        "Robinson Crusoe",
        "Gulliver’s Travels",
        "Clarissa",
        "Tom Jones",
        "Emma"
    };
    
    private int IndexOf(string[] source, string searchFor, int min, int max)
    {
        if (min > max)  
        {  
            return -1;  
        }  
        
        var half = (max + min) / 2;
        var current = source[half];

        if (searchFor.Equals(current))
            return half;
        
        var length = Math.Max(searchFor.Length, current.Length);
        if (string.Compare(searchFor, 0, current, 0, length) < 0)
            return IndexOf(source, searchFor, min, half - 1);
        
        return IndexOf(source, searchFor, half + 1, max);
    }
    
    private int IndexOfLinear(string[] source, string searchFor)
    {
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i].Equals(searchFor))
                return i;
        }

        return -1;
    }
}