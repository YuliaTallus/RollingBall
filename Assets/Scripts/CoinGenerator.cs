using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    private float _yMin = -2f, _yMax = 1;
    private float _xMin = 0, _xMax = 20;
    private float _xOutOfDisplay = 10;
    private int _coinsAmount;

    private void Update()
    {
        _coinsAmount = FindObjectsOfType<Coin>().Length;

        if (_coinsAmount < 3)
        {
            GenerateCoins();
        }
    }

    private void GenerateCoins()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(_coin, GetRamdomPositionOnScreen(), Quaternion.identity);
        }
    }

    private Vector2 GetRamdomPositionOnScreen()
    {
        return new Vector2(transform.position.x + Random.Range(_xMin, _xMax) + _xOutOfDisplay, Random.Range(_yMin, _yMax));
    }
}

