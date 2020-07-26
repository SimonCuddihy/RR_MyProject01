using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputHandler))]
[RequireComponent(typeof(Rigidbody))]
public class CarController : MonoBehaviour
{
    public InputHandler iH;
    public List<WheelCollider> throttleWheels;
    public List<GameObject> steeringWheels;
    public List<GameObject> wheelMeshes;
    public float horsepower = 20000f;
    public float maxTurnDegrees = 20f;
    public Rigidbody rigidBody;
    public Transform CM;
    public float frequency;
    
    // Start is called before the first frame update
    void Start()
    {
        iH = GetComponent<InputHandler>();
        rigidBody.GetComponent<Rigidbody>();

        if (CM)
        {
            rigidBody.centerOfMass = CM.position;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = horsepower * Time.deltaTime * iH.throttle;
        }

        foreach (GameObject wheel in steeringWheels)
        {
            wheel.GetComponent<WheelCollider>().steerAngle = maxTurnDegrees * iH.steer;
            wheel.transform.localEulerAngles = new Vector3(0f, iH.steer * maxTurnDegrees, 0f);
        }

        /*foreach (GameObject wheel in wheelMeshes)
        {
            wheel.transform.Rotate(rigidBody.velocity.magnitude * (transform.InverseTransformDirection(rigidBody.velocity).z >= 0 ? 1 : -1) / (2 * Mathf.PI * 0.33f), 0f, 0f);
        }*/

        foreach (GameObject wheel in wheelMeshes)
        {
            frequency = rigidBody.velocity.magnitude / (wheel.GetComponentInParent<WheelCollider>().radius * 2 * Mathf.PI);

            wheel.transform.Rotate(
                2 * Mathf.PI * frequency * (transform.InverseTransformDirection(rigidBody.velocity).z < 0 ? (-1) : 1),
                0f, 0f);
        }

    }
}
