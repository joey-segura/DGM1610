using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateBat : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        followUpdate parentScript = gameObject.GetComponentInParent<followUpdate>();
        if (parentScript.chasing)
        {
            animator.SetBool("Chasing", true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GC")
        {
            this.gameObject.SetActive(false);
        }
        if (other.gameObject.name == "GC2")
        {
            this.gameObject.SetActive(false);
        }
    }
}
