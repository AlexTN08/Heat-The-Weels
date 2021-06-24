using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{

    public bool steer;
    public bool invertSteer;
    public bool power;

    public float steerAngle { get; set; }
    public float torque { get; set; } // cuplu

    private WheelCollider wheelColider;
    private Transform wheelTransform;

    // Start is called before the first frame update
    void Start()
    {
        wheelColider = GetComponentInChildren<WheelCollider>();
        wheelTransform = GetComponentInChildren<MeshRenderer>().GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        wheelColider.GetWorldPose(out Vector3 pos, out Quaternion rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
    }
    private void FixedUpdate()
    {
        if(steer)
        {
            wheelColider.steerAngle = steerAngle * (invertSteer ? -1 : 1);
        }

        if (power)
        {
            wheelColider.motorTorque = torque;
        }

    }
}
