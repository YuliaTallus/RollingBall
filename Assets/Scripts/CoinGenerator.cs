using UnityEngine;
using System.Collections.Generic;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _coin;

    private float _yMin = -2f, _yMax = 1;
    private float _xMin = 0, _xMax = 20;
    private float _xOutOfDisplay = 10;
    private static List<Coin> _coinsOnScene = new List<Coin>();

    private void Update()
    {
        if (_coinsOnScene.Count < 3)
        {
            GenerateCoins();
        }
    }

    private void GenerateCoins()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector2 _randomPosition = GetRamdomPositionOnScreen();
            if (!isCoinOrObstacleIntersect(_randomPosition))
            {
                Coin coin = Instantiate(_coin, _randomPosition, Quaternion.identity).GetComponent<Coin>();
                _coinsOnScene.Add(coin);
            }
        }
    }

    private Vector2 GetRamdomPositionOnScreen()
    {
        return new Vector2(transform.position.x + Random.Range(_xMin, _xMax) + _xOutOfDisplay, Random.Range(_yMin, _yMax));
    }

    public void DeleteCoin(Coin coin)
    {
        _coinsOnScene.Remove(coin);
    }

    private bool isCoinOrObstacleIntersect(Vector2 position)
    {
        float radiusToCheck = 0.5f;
        return Physics2D.OverlapCircle(position, radiusToCheck);
    }
}

