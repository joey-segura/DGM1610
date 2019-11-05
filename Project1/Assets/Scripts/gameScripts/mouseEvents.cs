using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseEvents : MonoBehaviour
{
    private Camera cam;
    public vector3Data data;

    private void Start()
    {
        cam = Camera.main;
    }
    private void OnMouseDown()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit))
        {
            data.value = hit.point;
        }
    }
}
