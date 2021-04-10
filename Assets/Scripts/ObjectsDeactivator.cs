using UnityEngine;
using UnityEngine.Events;

public class ObjectsDeactivator : MonoBehaviour
{
    public event UnityAction Deactivated;

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        Deactivated();
    }
}
