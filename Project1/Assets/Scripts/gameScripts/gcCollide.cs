using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gcCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GC")
        {
            this.gameObject.SetActive(false);
        }
        if (other.gameObject.name == "GC2")
        {
            this.gameObject.SetActive(false);
        }
    }
}
