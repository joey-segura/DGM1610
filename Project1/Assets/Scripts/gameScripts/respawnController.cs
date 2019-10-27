using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.transform.position);
        player.transform.position = respawn.transform.position;
    }
}