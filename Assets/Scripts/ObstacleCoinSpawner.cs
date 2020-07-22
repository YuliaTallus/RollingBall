using UnityEngine;
using System;
using System.Collections.Generic;

public class ObstacleCoinSpawner : MonoBehaviour
{
    [SerializeField] private ObjectsDeactivator _objectsDeactivator;
    [SerializeField] private GameObject _coin;
    [SerializeField] private GameObject _obstacle;

    private float _xOutOfScreen = 11f;
    private float _yCoinMin = -2f, _yCoinMax = 1;
    private float _yObstaclePosition = -2.785f;
    private float _scaleObstacleMin = 1, _scaleObstacleMax = 2.5f;
    float lastSpawnedObjectXPosition = 11f;

    private List<GameObject> pooledCoins = new List<GameObject>();
    private List<GameObject> pooledObstacles = new List<GameObject>();

    private void Awake()
    {
        PoolCoinsAndObstacles();
        _objectsDeactivator.Deactivated += SpawnObstacleOrCoin;
    }

    private void SpawnObstacleOrCoin()
    {
        bool whatToSpawn = ChooseCoinOrObstacle();

        if (whatToSpawn)
        {
            float coinsLineYPosition = UnityEngine.Random.Range(_yCoinMin, _yCoinMax);

            for (int i = 0; i < 3; i++)
            {
                GameObject newCoin = GetPooledObject(pooledCoins);
                if (newCoin != null)
                {
                    newCoin.transform.position = new Vector2(lastSpawnedObjectXPosition + 1, coinsLineYPosition);
                    newCoin.SetActive(true);                    
                    lastSpawnedObjectXPosition = newCoin.transform.position.x;
                }
 
            }
        }
        else
        {
            GameObject newObstacle = GetPooledObject(pooledObstacles);
            newObstacle.transform.position = new Vector2(lastSpawnedObjectXPosition + 2, _yObstaclePosition);
            newObstacle.transform.localScale = new Vector2(UnityEngine.Random.Range(_scaleObstacleMin, _scaleObstacleMax), UnityEngine.Random.Range(_scaleObstacleMin, _scaleObstacleMax));
            newObstacle.SetActive(true);
            lastSpawnedObjectXPosition = newObstacle.transform.position.x;
        }
    }

    private bool ChooseCoinOrObstacle()
    {
        return UnityEngine.Random.Range(1, 100) <= 50 ? true : false;
    }

    private void PoolCoinsAndObstacles()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject coinToPool = Instantiate(_coin);
            coinToPool.SetActive(false);
            pooledCoins.Add(coinToPool);

            GameObject obstacleToPool = Instantiate(_obstacle);
            obstacleToPool.SetActive(false);
            pooledObstacles.Add(obstacleToPool);
        }
    }

    private GameObject GetPooledObject(List<GameObject> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (!list[i].activeInHierarchy)
            {
                return list[i];
            }
        }
        return null;
    }

}
