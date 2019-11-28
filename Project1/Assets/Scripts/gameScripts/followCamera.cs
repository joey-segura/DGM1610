//https://www.youtube.com/watch?v=MFQhpwc6cKE
using System;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
public class followCamera : MonoBehaviour
{
    public Transform focus;
    public float followSpeed = 10f;
    public Vector3 distance;
    private void Start()
    {
        focus = GameObject.Find("player(Clone)").transform;
    }
    private void LateUpdate()
    {
        Vector3 desiredPosition = focus.position + distance; 
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed*Time.deltaTime); 
        transform.position = smoothedPosition;
    }
}
