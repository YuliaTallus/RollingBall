using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform Target;

    private float _speed = 0.1f;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(Target.position.x, transform.position.y, transform.position.z), _speed);
    }
}
