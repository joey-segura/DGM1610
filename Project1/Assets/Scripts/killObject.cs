using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class killObject : MonoBehaviour
{
    public UnityEvent die;

    private void OnMouseDown()
    {
        die.Invoke();
    }
}
