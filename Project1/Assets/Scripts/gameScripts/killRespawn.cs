using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killRespawn : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;

    private void Start()
    {
        respawnPoint = GameObject.Find("respawnPoint").transform;
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.name == "net")
        {
            this.gameObject.transform.position = respawnPoint.position;
        }
    }
}    
