using UnityEngine;

public class GroundChecking : MonoBehaviour
{
    public Transform Point;
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
