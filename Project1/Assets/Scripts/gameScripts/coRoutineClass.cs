using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coRoutineClass : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            Debug.Log("Working");
            CallCoRoutine();
        }
    }
    public void CallCoRoutine()
    {
        StartCoroutine(OnRun());
    }
    IEnumerator OnRun()
    {
        yield return new WaitForSeconds(3f);
            Debug.Log("Hello.");
    }
}
