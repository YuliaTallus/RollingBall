using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int CoinAmount { get; private set; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Coin>())
        {
            CoinAmount++;
        }
    }
}
