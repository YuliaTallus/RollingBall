using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField]
    public Transform Point;

    [SerializeField]
    public float Radius;
    public LayerMask GroundLayer;

    public bool CheckGround()
    {
        if (Physics2D.OverlapCircle(Point.position, Radius, GroundLayer))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
