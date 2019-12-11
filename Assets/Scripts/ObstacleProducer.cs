using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProducer : MonoBehaviour
{
    private float _xMin = 10, _xMax = 200, _yPosition = -2.785f;
    public GameObject Obstacle;
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Instantiate(Obstacle, new Vector2(Random.Range(_xMin, _xMax), _yPosition), Quaternion.identity);
        }
    }

}
