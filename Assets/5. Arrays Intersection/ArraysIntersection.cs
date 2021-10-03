using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace _5._Arrays_Intersection
{
    public class ArraysIntersection : MonoBehaviour
    {
        private void Start()
        {
            LogIntersection(new []{4,1,6,8}, new []{1,8,5});
            LogIntersection(new []{1,9,7}, new []{2,4,6,9});
            LogIntersection(new []{3,5,1}, new []{6,9});
        }

        private void LogIntersection(int[] arrayA, int[] arrayB)
        {
            var set = new HashSet<int>(arrayA);
            set.IntersectWith(arrayB);

            var strBuilder = new StringBuilder();
            foreach (var value in set)
            {
                strBuilder.Append(value);
                strBuilder.Append(';');
                strBuilder.Append(' ');
            }
            Debug.Log(strBuilder);
        }
    }
}