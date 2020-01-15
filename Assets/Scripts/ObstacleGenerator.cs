using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    private float _xMin = 10, _xMax = 200;
    private float _yPosition = -2.785f;
    private float _scaleMin = 1, _scaleMax = 2.5f;

    [SerializeField] private GameObject _obstacle;

    private void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Vector2 _randomPosition = new Vector2(Random.Range(_xMin, _xMax), _yPosition);
            float _randomXScale = Random.Range(_scaleMin, _scaleMax);
            float _randomYscale = Random.Range(_scaleMin, _scaleMax);

            Instantiate(_obstacle, _randomPosition, Quaternion.identity).transform.localScale = new Vector3(_randomXScale, _randomYscale, 1);
        }
    }
}
