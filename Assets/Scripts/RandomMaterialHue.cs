﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMaterialHue : MonoBehaviour
{
    public Material[] materialsToChange;
    public float saturation = 1.0f;
    public float brightness = 1.0f;
    public float alpha = 1.0f;


    // Update is called once per frame
    void Update()
    {
        HSBColor newColor = new HSBColor(Random.value, saturation, brightness, alpha);

        foreach (Material mat in materialsToChange)
        {
            mat.color = newColor.ToColor();
            //GetComponent<Renderer>().material.color = newColor.ToColor();
        }

    }
}
