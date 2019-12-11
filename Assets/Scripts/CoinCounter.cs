using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int CoinAmount;

    void Start()
    {
        CoinAmount = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            CoinAmount++;
            Debug.Log(CoinAmount);
        }
    }
}
