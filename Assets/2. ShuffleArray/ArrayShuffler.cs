using System.Linq;
using System.Text;
using UnityEngine;

namespace _2._ShuffleArray
{
    public class ArrayShuffler : MonoBehaviour
    {
        private readonly int[] _source = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        private void Start()
        {
            LogArray();
            Shuffle1();
            LogArray();
        }

        private void Shuffle1()
        {
            var copy = _source.ToList();
            for (var i = 0; i < _source.Length; i++)
            {
                var randomIndex = Random.Range(0, copy.Count);
                _source[i] = copy[randomIndex];
                copy.RemoveAt(randomIndex);
            }
        }

        private void Shuffle2()
        {
            for (var i = 0; i < _source.Length; i++)
            {
                var j = Random.Range(0, _source.Length - i) + i;
                var temp = _source[i];
                _source[i] = _source[j];
                _source[j] = temp;
            }
        }
        
        private void LogArray()
        {
            var strBuilder = new StringBuilder();
            foreach (var s in _source)
            {
                strBuilder.Append(s);
                strBuilder.Append(';');
            }
            Debug.Log(strBuilder.ToString());
        }
    }
}