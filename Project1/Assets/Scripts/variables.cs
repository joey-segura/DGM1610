using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class variables : MonoBehaviour
{
	public float floatValue = 5f;
	public int intValue;
	public string stringValue = "Bob";
	public int firePower;
	public UnityEvent Event;
	
	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
