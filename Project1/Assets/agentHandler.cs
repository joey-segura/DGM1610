using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentHandler : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform destinationobj;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(targetPlayer());
    }

    public IEnumerator targetPlayer()
    {
        yield return null;
        destinationobj = GameObject.Find("player(Clone)").transform;
    }

    void Update()
    {
        agent.destination = destinationobj.position;

        if (destinationobj.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (destinationobj.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        //transform.LookAt(destinationobj.position);
        //transform.Rotate(new Vector3(0, 90, 0), Space.Self);
    }
}