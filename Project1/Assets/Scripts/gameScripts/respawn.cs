using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private Transform beanBoy;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        beanBoy.transform.position = respawnPoint.transform.position;
    }
}    
    
    