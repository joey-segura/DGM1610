using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour
{
    private SpriteRenderer rendr;
    void Start()
    {
        rendr = this.gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rendr.enabled = !rendr.enabled;
        }
    }
}
