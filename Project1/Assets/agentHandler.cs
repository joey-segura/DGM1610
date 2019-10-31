using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentHandler : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform destinationobj;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = destinationobj.position;
    }
}
