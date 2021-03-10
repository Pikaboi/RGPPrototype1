using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    //Movement Based Variables
    public CharacterController controller;

    public float speed = 12.0f;

    public float gravity = -9.81f;

    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

    //Interaction Based Variables
    private bool bInteract = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Falling Down
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;
      
        //Get input axes
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        //Move with local dir
        Vector3 move = transform.right * x + transform.forward * y;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        
        //Fall down
        controller.Move(velocity * Time.deltaTime);

        //Check if player hit the button
        if (Input.GetKeyDown(KeyCode.E)){
            //Now we check if we are letting it do anything
            if(bInteract == true)
            {
                //We can interact now
            }
        }
    }

    public void enableInteract()
    {
        bInteract = true;
    }

    public void disableInteract()
    {
        bInteract = false;
    }
}
