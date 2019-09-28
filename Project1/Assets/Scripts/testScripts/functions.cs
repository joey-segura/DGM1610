using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    public string playerName;
    public float speed = 5f;
    public GameObject player;
    

    void Start()
    {
        Instantiate(ConfigGameObject());
    }

    //Create Player;
    private GameObject ConfigGameObject()
    {
        player.layer = 0;
        player.active = true;
        player.tag = "Player";
        player.transform.position = Vector3.zero;
        player.name = playerName;

        return player;
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = IncreaseSpeed(2f);
    }
    private float IncreaseSpeed(float multiplier)
    {
        return speed * multiplier;
    }
}
