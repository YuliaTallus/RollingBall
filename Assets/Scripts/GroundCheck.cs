using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private float _radius;
    public LayerMask GroundLayer;

    public bool CheckGround()
    {
        return Physics2D.OverlapCircle(_point.position, _radius, GroundLayer);
    }
}
