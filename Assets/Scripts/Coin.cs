using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<BallMovement>())
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
