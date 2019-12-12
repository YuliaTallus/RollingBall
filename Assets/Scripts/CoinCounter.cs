using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public int CoinAmount;
    public TMP_Text Score;

    void Start()
    {
        CoinAmount = 0;
    }

    private void Update()
    {
        Score.text = CoinAmount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            CoinAmount++;
        }
    }
}
