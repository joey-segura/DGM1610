using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class coRoutine : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float seconds = 10f;
    private int i = 10;
    public int counter;
    public bool canRun;
    private WaitForSeconds wfsObj;

    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds);
        CallCoRoutine();
    }
    
    public void CallCoRoutine()
    {
        StartCoroutine(RunCoRoutine());
    }
    
    IEnumerator RunCoRoutine()
    {
        startEvent.Invoke();
        
        while (i > 0)
        {
            repeatEvent.Invoke();
            yield return new WaitForSeconds(1f);
            counter--;
        }
        while (canRun == true)
        {
            repeatEvent.Invoke();
            yield return new WaitForSeconds(1f);
            counter--;
        }
        endEvent.Invoke();
    }
}
