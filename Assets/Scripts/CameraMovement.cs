using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;
    private Transform _camTransform;
    void Start()
    {
        _camTransform = GetComponent<Transform>();
    }

    void Update()
    {
        _camTransform.SetPositionAndRotation(new Vector3(Target.position.x, _camTransform.position.y, _camTransform.position.z), Quaternion.identity);
    }
}
