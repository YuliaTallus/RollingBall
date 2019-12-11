using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    private Transform m_rigidBall;
    private float m_horizontalInput;
    public float AngularSpeed;

    void Start()
    {
        m_rigidBall = GetComponent<Transform>();
    }

    void Update()
    {
        m_horizontalInput = Input.GetAxisRaw("Horizontal");
        m_rigidBall.Rotate(new Vector3(0, 0, m_horizontalInput) * AngularSpeed);
    }
}
