using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCheck : MonoBehaviour
{
    private void Update()
    {
        if (GameObject.Find("player") != null)
        {
           Debug.Log("I am here.");
        }
        else
        {
            Debug.Log("I am not here.");
        }
    }
}
