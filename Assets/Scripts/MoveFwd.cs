using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFwd : MonoBehaviour
{
    public float speed = 15.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
