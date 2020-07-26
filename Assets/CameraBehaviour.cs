using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject target;
    public float distance = 5f;
    public float height = 2f;
    public float dampening = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,
            target.transform.position + target.transform.TransformDirection(new Vector3(0f, height, -distance)),
            dampening * Time.deltaTime);
        transform.LookAt(target.transform);
    }
}
