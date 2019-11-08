using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow: MonoBehaviour
{
    public Transform target;
    public float followSpeed = 1f;
    public Vector3 distance;
    private void Update()
    {
        target = GameObject.Find("player(Clone)").transform;
    }
    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + distance; 
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed*Time.deltaTime); 
        transform.position = smoothedPosition;
    }
}