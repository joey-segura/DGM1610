using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followUpdate : MonoBehaviour
{
    public GameObject target;
    void Update()
    {
        target = GameObject.Find("player(Clone)");
        if (target != null)
        {
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, target.transform.position, 0.1f);
        }
    }
}
