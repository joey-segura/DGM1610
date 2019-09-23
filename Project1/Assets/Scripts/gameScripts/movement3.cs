﻿using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class movement3 : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;
    public float moveSpeed = 10f, gravity = 1f, jumpSpeed = 15f;
    public int jumpCount;
    public int jumpCountMax = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(position*Time.deltaTime);
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        position.y -= gravity;
        
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
    }
}
