using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayText : MonoBehaviour
{
    public GameObject welcomeNote;
    private void Start()
    {
        welcomeNote.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        {
            welcomeNote.SetActive(false);
        }
    }
}
