using UnityEngine;

public class BallRotation : MonoBehaviour
{
    private Transform _rigidBall;
    private float _horizontalInput;
    [SerializeField] private float _angularSpeed;

    private void Start()
    {
        _rigidBall = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _rigidBall.Rotate(new Vector3(0, 0, _horizontalInput) * _angularSpeed);
    }
}
