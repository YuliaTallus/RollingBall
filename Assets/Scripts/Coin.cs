using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private CoinGenerator _coinGenerator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<BallMovement>())
        {
            _coinGenerator.DeleteCoin(gameObject.GetComponent<Coin>());
            Destroy(gameObject, 0.1f);
        }

        if (collision.gameObject.GetComponent<Coin>() || collision.gameObject.GetComponent<Obstacle>())
        {
            _coinGenerator.DeleteCoin(gameObject.GetComponent<Coin>());
            Destroy(gameObject);
        }
    }
}
