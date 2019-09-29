using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lead : MonoBehaviour
{
    public float speed;
    public Rigidbody enemyRB;
    void Update ()
    {
        float moveHorizontal = -1;
        float moveVertical = 0;

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        enemyRB.AddForce(movement * speed);
    }
}
