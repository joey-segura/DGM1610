using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class extinguish : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Dog")
        {
            print("GOOD JOB!");
            Destroy(this.gameObject);
        }
    }
}
