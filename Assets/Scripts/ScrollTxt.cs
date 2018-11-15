using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTxt : MonoBehaviour
{
    public Vector2 scrollSpeed = Vector2.one;
    public Material mat;


    // Use this for initialization
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        //mat = GetComponent<Renderer>().GetComponent<Material>();        
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset += scrollSpeed * Time.deltaTime;
    }
}
