﻿ using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeWood: MonoBehaviour
{
    //[]array
    public Material[] material;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[0];
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("burntWood"))
        {
            rend.sharedMaterial = material[1];
        }
    }
}
