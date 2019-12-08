using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D m_rigidBall;
    private float m_horizontalInput;
    public float Speed, AngularSpeed, JumpForce;
    void Start()
    {
        m_rigidBall = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        m_horizontalInput = Input.GetAxisRaw("Horizontal");
        m_rigidBall.velocity = new Vector2(m_horizontalInput * Speed, m_rigidBall.velocity.y);
        m_rigidBall.angularVelocity = m_horizontalInput * AngularSpeed;

        Jump();
    }

    void Jump() 
    {
        if (Input.GetKeyDown("space")) 
        {
            m_rigidBall.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
        }
    }
}
