using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject, 0.1f);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin") || collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
