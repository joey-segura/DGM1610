using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryPush : MonoBehaviour
{
    public float push = 5.0f;
    private movement3 speedAccess;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rb = hit.collider.attachedRigidbody;

        if (rb == null || rb.isKinematic)
        {
            return;
        }

        if (hit.moveDirection.y < -0.3f)
        {
            return;
        }

        push = speedAccess.moveSpeed;

        Vector3 direction = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        rb.velocity = direction * push;
    }
    private void Start()
    {
        speedAccess = gameObject.GetComponent<movement3>();
    }
}
