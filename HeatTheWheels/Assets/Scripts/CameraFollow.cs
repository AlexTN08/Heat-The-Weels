using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float smoothSpeed = 0.125f;

    private void Start()
    {
       
    }

    private void Update()
    {
        Vector3 possitions = target.position + target.TransformDirection(offset);

        Vector3 smoothedPossition = Vector3.Lerp(transform.position, possitions, smoothSpeed);
        transform.position = smoothedPossition;

        transform.LookAt(target);
    }
}

