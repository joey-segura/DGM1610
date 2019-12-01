using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public GameObject popUpTextPrefab;
    public void OnTriggerEnter(Collider other)
    {
        if (popUpTextPrefab)
        {
            ShowpopUpText();
        }
    }
    private void ShowpopUpText()
    {
        Instantiate(popUpTextPrefab, transform.position, Quaternion.identity, transform);
    }
}
