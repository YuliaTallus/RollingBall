using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinProducer : MonoBehaviour
{
    public GameObject Coin;
    private float _yMin = -2f, _yMax = 1, _xMin = 0, _xMax = 20, _xOutOfDisplay = 10;
    private GameObject[] coinsArray;

    void Update()
    {
        coinsArray = GameObject.FindGameObjectsWithTag("Coin");

        if (coinsArray.Length < 3)
        {
            ProduceCoins();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    private void ProduceCoins()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Coin, new Vector2(transform.position.x + Random.Range(_xMin, _xMax) + _xOutOfDisplay, Random.Range(_yMin, _yMax)), Quaternion.identity);
        }
    }
}

