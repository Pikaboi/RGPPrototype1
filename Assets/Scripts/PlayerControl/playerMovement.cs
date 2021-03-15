using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    //Movement Based Variables
    public CharacterController controller;

    public float age = 5;

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
    private bool bNumpadInteract = false;
    private InteractNumpad cNumpad;
    private bool bDoorInteract = false;
    private DoorOpen cDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject.FindGameObjectWithTag("MainCamera").transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y + age / 10 , transform.position.z), GameObject.FindGameObjectWithTag("MainCamera").transform.rotation);

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
            //Also Checking for a numpad to start its puzzle
            if(bNumpadInteract == true)
            {
                cNumpad.turnOn();
            }
            if(bDoorInteract == true)
            {
                cDoor.OpenDoor();
            }
        }

        //Crouching
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Scale down to crouch
            // transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
            GetComponent<CharacterController>().height = 1.6f;
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            //Scale back up after crouch
            //transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);
            GetComponent<CharacterController>().height = 3.2f;
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
    //Enable an interaction with a lock puzzle
    public void enableNumpadInteract(InteractNumpad cNum)
    {
        bNumpadInteract = true;
        cNumpad = cNum;

    }
    //Enable an interaction with a Door
    public void enableDoorInteract(DoorOpen cDoorOpen)
    {
        bDoorInteract = true;
        cDoor = cDoorOpen;

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
    //Remove Interactibility with a lock puzzle
    public void disableNumpadInteract()
    {
        bNumpadInteract = false;
    }
    //Remove Interactibility with a door
    public void disableDoorInteract()
    {
        bDoorInteract = false;
    }
}
