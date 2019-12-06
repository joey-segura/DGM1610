using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public GameObject popUpTextPrefab;
    IEnumerator OnTriggerEnter(Collider other)
    {
        if (popUpTextPrefab && other.gameObject.name == "jumpUP")
        {
            movement3 movement3 = GetComponent<movement3>();
            movement3.canMove = false;
            
            ShowpopUpText();
            
            yield return new WaitForSeconds (3);

            movement3.canMove = true;
        }
    }
    private void ShowpopUpText()
    {
        {
            Instantiate(popUpTextPrefab, transform.position, Quaternion.identity, transform);
        }
    }
}
