using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLife : MonoBehaviour
{
    public float rotationSpeed = 30.0f;
    public Vector3 axis = Vector3.forward;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(axis, rotationSpeed * Mathf.Deg2Rad * Time.deltaTime);
    }
}
