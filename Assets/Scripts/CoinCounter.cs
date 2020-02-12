using UnityEngine;
using UnityEngine.Events;

public class CoinCounter : MonoBehaviour
{
    public int CoinsAmount { get; private set; }

    public event UnityAction Changed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Coin>())
        {
            CoinsAmount++;
            Changed();
        }
    }
}
