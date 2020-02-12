using UnityEngine;

public class ObstacleCoinSpawner : MonoBehaviour
{
    [SerializeField] private ObjectsDestroyer _objectsDestroyer;
    [SerializeField] private GameObject _coin;
    [SerializeField] private GameObject _obstacle;

    private float _xOutOfScreen = 11f;
    private float _yCoinMin = -2f, _yCoinMax = 1;
    private float _yObstaclePosition = -2.785f;
    private float _scaleObstacleMin = 1, _scaleObstacleMax = 2.5f;

    private void Awake()
    {
        _objectsDestroyer.Destroyed += SpawnObstacleOrCoin;
    }

    private void SpawnObstacleOrCoin()
    {
        bool whatToSpawn = ChooseCoinOrObstacle();
        if (whatToSpawn)
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(_coin, new Vector2(transform.position.x + _xOutOfScreen + i, Random.Range(_yCoinMin, _yCoinMax)), Quaternion.identity);
            }
        }
        else
        {
            Instantiate(_obstacle, new Vector2(transform.position.x + _xOutOfScreen, _yObstaclePosition), Quaternion.identity).transform.localScale
                = new Vector3(Random.Range(_scaleObstacleMin, _scaleObstacleMax), Random.Range(_scaleObstacleMin, _scaleObstacleMax), 1);
        }
    }

    private bool ChooseCoinOrObstacle()
    {
        return Random.Range(1, 100) <= 30 ? true : false;
    }
}
