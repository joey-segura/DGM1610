using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gcCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
