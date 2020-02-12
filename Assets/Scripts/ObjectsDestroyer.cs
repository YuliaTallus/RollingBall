using UnityEngine;
using UnityEngine.Events;

public class ObjectsDestroyer : MonoBehaviour
{
    public event UnityAction Destroyed;

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroyed();
    }
}
