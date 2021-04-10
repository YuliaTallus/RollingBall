using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private float _speed = 10f;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(_target.position.x, transform.position.y, transform.position.z), _speed * Time.deltaTime);
    }
}
