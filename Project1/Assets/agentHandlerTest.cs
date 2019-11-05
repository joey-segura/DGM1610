
using System;
using UnityEngine;
using UnityEngine.AI;

public class agentHandlerTest : MonoBehaviour
{
    private NavMeshAgent agent;
    public vector3Data location;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = location.value;
    }
}