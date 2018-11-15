using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTower : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.forward, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
    }
}
