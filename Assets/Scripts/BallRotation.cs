using UnityEngine;

public class BallRotation : MonoBehaviour
{
    private Transform _rigidBall;
    private float _horizontalInput;
    public float AngularSpeed;

    void Start()
    {
        _rigidBall = GetComponent<Transform>();
    }

    void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _rigidBall.Rotate(new Vector3(0, 0, _horizontalInput) * AngularSpeed);
    }
}
