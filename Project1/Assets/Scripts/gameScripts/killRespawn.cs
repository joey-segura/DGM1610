using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killRespawn : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "respawnPoint")
        {
            this.gameObject.transform.position = respawnPoint.position;
        }
    }
}    
