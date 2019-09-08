using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

	public float speed;

	private Rigidbody PlayerRB;

	// Use this for initialization
	void Start ()
	{
		PlayerRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float moveHorizontal = 0;
		float moveVertical = 0;
		
		if (Input.GetKey("up"))
		{
			moveVertical = 1;
		}
		if (Input.GetKey("down"))
		{
			moveVertical = -1;
		}
		if (Input.GetKey("right"))
		{
			moveHorizontal = 1;
		}
		if (Input.GetKey("left"))
		{
			moveHorizontal = -1;
		}

		Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
		Debug.Log(movement);
		PlayerRB.AddForce(movement * speed);
	}
}
