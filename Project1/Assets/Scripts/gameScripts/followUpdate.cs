using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followUpdate : MonoBehaviour
{
    public GameObject target;
    public Transform followPoint;
    public int triggerRange;

    private void Start()
    {
        StartCoroutine(GetPlayer());
    }

    public IEnumerator GetPlayer()
    {
        yield return null;
        target = GameObject.Find("player(Clone)");
        followPoint = target.transform;
    }
    void Update()
    {
        transform.LookAt(followPoint);
        if (target != null)
        {
            if((Vector3.Distance(transform.position,target.transform.position)<triggerRange))
            {
                this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position,
                    target.transform.position, 0.1f);
            }
        }
    }
}

