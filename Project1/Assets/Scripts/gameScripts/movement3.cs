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
    void Start()
    {
        controller = GetComponent<CharacterController>();
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
        Vector3 newScale = transform.localScale;
        controller.Move(position*Time.deltaTime);
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        position.y -= gravity;
        rogueController.SetFloat("Speed", Mathf.Abs(position.x));
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
        if (Input.GetAxis("Horizontal") < 0)
        {
            newScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            newScale.x = 1;
        }
        transform.localScale = newScale;
    }
}
