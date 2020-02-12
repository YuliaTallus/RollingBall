using UnityEngine;

public class BallRotation : MonoBehaviour
{
    private Transform _transform;

    [SerializeField] private float _angularSpeed;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        float _horizontalInput = Input.GetAxisRaw("Horizontal");
        _transform.Rotate(new Vector3(0, 0, Mathf.Clamp(_horizontalInput, 0, 1)) * _angularSpeed);
    }
}
