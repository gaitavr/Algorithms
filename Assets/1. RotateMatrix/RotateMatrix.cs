using System.Text;
using TMPro;
using UnityEngine;

public class RotateMatrix : MonoBehaviour
{
    private readonly int[,] _matrix =
    {
        {1, 2, 3, 4, 7},
        {4, 3, 2, 5, 8},
        {5, 2, 1, 5, 4},
        {6, 5, 3, 1, 9},
        {2, 6, 1, 8, 3},
    };
    
    private void Start()
    {
        Debug.LogError(_matrix[3,0]);
        LogMatrix(_beforeRotationText);
        Rotate();
        LogMatrix(_afterRotationText);
    }
    
    [SerializeField]
    private TextMeshProUGUI _beforeRotationText;
    [SerializeField]
    private TextMeshProUGUI _afterRotationText;
    
    private void LogMatrix(TextMeshProUGUI destination)
    {
        var strBuilder = new StringBuilder();
        for (var i = 0; i < _matrix.GetLength(0); i++)
        {
            for (var j = 0; j < _matrix.GetLength(1); j++)
            {
                strBuilder.Append(_matrix[i, j]);
            }
            strBuilder.Append("\n");
        }

        destination.text = strBuilder.ToString();
    }
    
    private void Rotate()
    {
        var n = _matrix.GetLength(0);
        for (var layer = 0; layer < n / 2; layer++)
        {
            var first = layer;
            var last = n - 1 - layer;
            for (var i = first; i < last; i++)
            {
                var offset = i - first;
                var temp = _matrix[first, i];
                
                _matrix[first, i] = _matrix[last - offset, first];
                _matrix[last - offset, first] = _matrix[last, last - offset];
                _matrix[last, last - offset] = _matrix[i, last];
                _matrix[i, last] = temp;
            }
        }
    }
}
