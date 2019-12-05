using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class movement3 : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;
    public float moveSpeed = 10f, gravity = 1f, jumpSpeed = 15f;
    public int jumpCount;
    public int jumpCountMax = 2;
    public Animator rogueController;
    public bool canMove;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        canMove = true;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "jumpUP")
        {
            jumpCountMax = 3;
        }
    }
    void Update()
    {
        if (canMove == true)
        {
            controller.Move(position*Time.deltaTime);
            position.x = moveSpeed*Input.GetAxis("Horizontal");
            position.y -= gravity;
            rogueController.SetFloat("Speed", Mathf.Abs(position.x));
        }
        
        if (canMove == true && controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        
        if (canMove == true && Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        
        if (canMove == true && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        
        if (canMove == true && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }
}
