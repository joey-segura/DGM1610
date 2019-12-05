using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public GameObject popUpTextPrefab;

    public void OnTriggerEnter(Collider other)
    {
        if (popUpTextPrefab && other.gameObject.name == "jumpUP")
        {
            ShowpopUpText();
        }
    }

    private void ShowpopUpText()
    {
        {
            Instantiate(popUpTextPrefab, transform.position, Quaternion.identity, transform);
        }
    }
}
