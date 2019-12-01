using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateText : MonoBehaviour
{
    public float DestroyText = 3f;
    public Vector3 offset = new Vector3(0,2,0);
    void Start()
    {
        Destroy(gameObject, DestroyText);

        this.transform.position += offset;
    }
}
