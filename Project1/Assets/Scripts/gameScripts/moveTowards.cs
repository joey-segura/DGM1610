﻿using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class moveTowards : MonoBehaviour
{
    private GameObject target;
    public Transform enemy;
    void Start()
    {
        target = GameObject.Find("player");
    }
    void Update()
    {
        if (enemy.position.y >= -1)
        {
             
        }
        else
        {
            enemy.position = Vector2.MoveTowards(enemy.position, target.transform.position, 0.1f);
        }
    }
}