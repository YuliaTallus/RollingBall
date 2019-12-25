using UnityEngine;
using UnityEngine.Events;

public class CoinCounter : MonoBehaviour
{
    public UnityEvent OnChange;
    private int _coinAmount;

    public int CoinAmount
    {
        get
        {
            return _coinAmount;
        }
        private set
        {
            _coinAmount = value;
            OnChange.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Coin>())
        {
            CoinAmount++;
        }
    }
}
