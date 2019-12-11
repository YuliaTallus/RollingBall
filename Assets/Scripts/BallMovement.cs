using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D m_rigidBall;
    private float m_horizontalInput, _newPosition, _xMin = -6, _xMax = 200;
    public float Speed, JumpForce;
    private GroundChecking m_groundChecker;

    void Start()
    {
        m_rigidBall = GetComponent<Rigidbody2D>();
        m_groundChecker = GetComponent<GroundChecking>();
    }

    void Update()
    {
        m_horizontalInput = Input.GetAxisRaw("Horizontal");

        Jump();

        m_rigidBall.velocity = new Vector2(m_horizontalInput * Speed, m_rigidBall.velocity.y);
        _newPosition = Mathf.Clamp(m_rigidBall.position.x, _xMin, _xMax);
        m_rigidBall.position = new Vector2(_newPosition, transform.position.y);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (m_groundChecker.CheckGround())
            {
                m_rigidBall.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
            }

        }
    }
}
