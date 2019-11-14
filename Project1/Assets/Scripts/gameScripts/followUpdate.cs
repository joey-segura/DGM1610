using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followUpdate : MonoBehaviour
{
    public GameObject target;
    public Transform followPoint;
    void Update()
    {
        transform.LookAt(followPoint);
        target = GameObject.Find("player(Clone)");
        followPoint = GameObject.Find("player(Clone)").transform;
        if (target != null)
        {
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, target.transform.position, 0.1f);
        }
    }
}

