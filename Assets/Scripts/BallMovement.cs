using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D _rigidBall;
    private float _horizontalInput, _newPosition, _xMin = -6, _xMax = 200;
    public float Speed, JumpForce;
    private GroundChecking _groundChecker;

    void Start()
    {
        _rigidBall = GetComponent<Rigidbody2D>();
        _groundChecker = GetComponent<GroundChecking>();
    }

    void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");

        Jump();

        _rigidBall.velocity = new Vector2(_horizontalInput * Speed, _rigidBall.velocity.y);
        _newPosition = Mathf.Clamp(_rigidBall.position.x, _xMin, _xMax);
        _rigidBall.position = new Vector2(_newPosition, transform.position.y);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (_groundChecker.CheckGround())
            {
                _rigidBall.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
            }

        }
    }
}
