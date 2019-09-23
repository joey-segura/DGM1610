using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeDeath : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "spikes")
        {
            print("YOU DIED");
            Destroy(this.gameObject);
        }
    }
}
