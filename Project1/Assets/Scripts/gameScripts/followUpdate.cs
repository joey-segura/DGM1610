using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followUpdate : MonoBehaviour
{
    public GameObject target;
    public Transform enemy;
    void Update()
    {
        target = GameObject.Find("player");
        enemy.position = Vector3.MoveTowards(enemy.position, target.transform.position, 0.1f);
    }
}
