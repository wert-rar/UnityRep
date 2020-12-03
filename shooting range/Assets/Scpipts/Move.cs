using UnityEngine;

public class Move : MonoBehaviour
{
    // movement
    private CharacterController controller;
        // movement on x / z
        public float speed = 10f;
        private float x, z;
    
        // movement on y 
        private Vector3 velocity;
        private float gravity = 9.81f;

    // Phusics
    private float jumpHeight = 2f;
    public LayerMask groundMask;
    public Transform groundcheck;
    private bool isGround;
    private float radiusOfCheck = 0.5f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(groundcheck.position, radiusOfCheck, groundMask);

        if (isGround && velocity.y < 0f)
        {
            velocity.y = -1f;
        }   
        if (Input.GetButtonDown("Jump"))
        {
                velocity.y = Mathf.Sqrt(jumpHeight * 2f * gravity);
        }
        // move on x / z Axis
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //move on y Axis
        velocity.y -= gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
