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
        _transform.Rotate(new Vector3(0, 0, Input.GetAxisRaw("Horizontal")) * _angularSpeed);
    }
}
