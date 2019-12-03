using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallFloor : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(FallDelay()); 
    }
    private IEnumerator FallDelay()
    {
        yield return new WaitForSeconds(2);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("hit");
            GetComponentInParent<Rigidbody>().useGravity = true;
            GetComponentInParent<Rigidbody>().isKinematic = false;
        }
    }
}
