using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class moveTowards : MonoBehaviour
{
    private Vector2 position;
    private GameObject target;
    public Transform enemy;
    void Start()
    {
        target = GameObject.Find("player(Clone)");
    }
    void Update()
    {
        if (enemy.position.y >= -1)
        {
            position.y = 0;
        }
        else
        {
            enemy.position = Vector2.MoveTowards(enemy.position, target.transform.position, 0.1f);
        }
    }
}
