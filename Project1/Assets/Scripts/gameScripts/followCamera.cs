﻿//https://www.youtube.com/watch?v=MFQhpwc6cKE
using UnityEngine;

public class followCamera : MonoBehaviour
{
    public Transform focus;
    public float followSpeed = 10f;
    public Vector3 distance;

    private void LateUpdate()
    {
        Vector3 desiredPosition = focus.position + distance;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed*Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
