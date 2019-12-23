﻿using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    private float _xMin = 10, _xMax = 200;
    private float _yPosition = -2.785f;

    [SerializeField]
    private GameObject Obstacle;
    private void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Instantiate(Obstacle, new Vector2(Random.Range(_xMin, _xMax), _yPosition), Quaternion.identity);
        }
    }
}
