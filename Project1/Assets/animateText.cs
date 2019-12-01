using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateText : MonoBehaviour
{
    public float DestroyText = 1f;
    public Vector3 Offset = new Vector3(0, 0, 0);
    void Start()
    {
        Destroy(gameObject, DestroyText);
        transform.localPosition += Offset;
    }

}
