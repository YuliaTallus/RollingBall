using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D _rigidBall;
    private float _horizontalInput;
    private float _newPosition;
    private float _xMin = -6;
    private float _xMax = 200;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    private GroundCheck _groundChecker;

    private void Start()
    {
        _rigidBall = GetComponent<Rigidbody2D>();
        _groundChecker = GetComponent<GroundCheck>();
    }

    private void FixedUpdate()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryJump();
        }

        MoveHorizontally(_speed);
    }

    private void TryJump()
    {
        if (_groundChecker.CheckGround())
        {
            _rigidBall.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void MoveHorizontally(float speed)
    {
        _rigidBall.velocity = new Vector2(_horizontalInput * speed, _rigidBall.velocity.y);
        _newPosition = Mathf.Clamp(_rigidBall.position.x, _xMin, _xMax);
        _rigidBall.position = new Vector2(_newPosition, transform.position.y);
    }
}
