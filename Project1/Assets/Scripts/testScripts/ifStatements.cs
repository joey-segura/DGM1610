using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class ifStatements : MonoBehaviour
{
    public int a = 5, b = 5, c = 10;
    public string password = "Friend";
    public bool lightsOn = false;
    void Start()
    {
        if (a+b == c);
        {
            print("True");
        }
        if (password != "OU812")
        {
            print("True");
        }
        if (!lightsOn)
        {
            print("True");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
