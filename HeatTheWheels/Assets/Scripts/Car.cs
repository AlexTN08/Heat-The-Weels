using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Transform centreOfMass;
    private float motorPower = 75f;
    private float maxSteer = 25f; //unghiul de rotire a rotilor

    public float Steer { get; set; }
    public float Throttle { get; set; }

    private Rigidbody _rigidbody;
    private Wheels[] wheels;

    // Start is called before the first frame update
    void Start()
    {
        wheels = GetComponentsInChildren<Wheels>(); // find wheels component in childre and put it in Wheels[] array.
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = centreOfMass.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Steer = GameManager.Instance.inputController.SteerInput;
        Throttle = GameManager.Instance.inputController.ThrottelInput;
        foreach(var wheel in wheels)
        {
            wheel.steerAngle = Steer * maxSteer;
            wheel.torque = Throttle * motorPower;
        }
    }
}
