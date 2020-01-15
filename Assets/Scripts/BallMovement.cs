using UnityEngine;

[RequireComponent(typeof(GroundCheck))]
[RequireComponent(typeof(Rigidbody2D))]
public class BallMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidBall;
    private GroundCheck _groundChecker;
    private float _xMin = -6;
    private float _xMax = 200;

    private void Start()
    {
        _rigidBall = GetComponent<Rigidbody2D>();
        _groundChecker = GetComponent<GroundCheck>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryJump();
        }

        float _horizontalInput = Input.GetAxisRaw("Horizontal");

        MoveHorizontally(_speed, _horizontalInput);
    }

    private void TryJump()
    {
        if (_groundChecker.CheckGround())
        {
            _rigidBall.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void MoveHorizontally(float speed, float horizontalInput)
    {
        _rigidBall.velocity = new Vector2(horizontalInput * speed, _rigidBall.velocity.y);
        float _newPosition = Mathf.Clamp(_rigidBall.position.x, _xMin, _xMax);
        _rigidBall.position = new Vector2(_newPosition, transform.position.y);
    }
}
