using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float _scaleMin = 1, _scaleMax = 3;
    private void Start()
    {
        gameObject.transform.localScale = new Vector3(Random.Range(_scaleMin, _scaleMax), Random.Range(_scaleMin, _scaleMax), 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin") || collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
