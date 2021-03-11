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
    private bool bHintInteract = false;
    private InteractibleHint cIHint;
    private bool bItemInteract = false;
    private InteractibleItem cIItem;

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
            if(bHintInteract == true)
            {
                //We can interact now
                cIHint.interactText();
            }
            //We also check if its an item that has the padlock number
            if(bItemInteract == true)
            {
                cIItem.interactCollect();
            }
        }
    }

    //Allow an interaction with a *HINT* item
    public void enableHintInteract(InteractibleHint cHint)
    {
        bHintInteract = true;
        cIHint = cHint;
    }
    //Allow an interaction with *PADLOCK CODE* item
    public void enableItemInteract(InteractibleItem cItem)
    {
        bItemInteract = true;
        cIItem = cItem;
    }

    //Remove the ability to interact to a *HINT* item
    public void disableHintInteract()
    {
        bHintInteract = false;
    }

    //Remove the ability to interact to a *PADLOCK CODE* item
    public void disableItemInteract()
    {
        bItemInteract = false;
    }
}
