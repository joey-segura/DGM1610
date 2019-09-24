using System.Security.Cryptography.X509Certificates;
using UnityEngine;
public class movement2 : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = 1f;
    public float jumpSpeed = 10f;
    
    public Vector3 position;
    public CharacterController controller;
    void Update()
    {
        controller.Move(position*Time.deltaTime);
        position.x = speed*Input.GetAxis("Horizontal");
        
        if (!controller.isGrounded)
        {
            position.y -= gravity;
        }
        if (Input.GetKeyDown("up"));
        {
            position.y = jumpSpeed;
        }
    }
}
