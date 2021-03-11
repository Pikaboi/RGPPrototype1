﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractibleHint : MonoBehaviour
{
    //This is a button on the UI canvas to show you can interact
    public Image ibuttonPrompt;
    [SerializeField]
    private string sClueText;
    // Start is called before the first frame update
    void Start()
    {
        //Turn off the button at the start
        ibuttonPrompt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Check if the player is in the area
        if(other.tag == "Player")
        {
            if (other.GetComponent<playerMovement>() != false)
            {
                //Show the button prompt
                ibuttonPrompt.enabled = true;

                //Now we can allow the player to activate his button press in movement
                other.GetComponent<playerMovement>().enableInteract(this);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Check if the player left the interactible area
        if(other.tag == "Player")
        {
            if (other.GetComponent<playerMovement>() != false)
            {
                //Remove the button promp
                ibuttonPrompt.enabled = false;

                //We want to turn off the ability to use the interact button too
                other.GetComponent<playerMovement>().disableInteract();
            }
        }
    }

    public void interactText()
    {
        Debug.Log(sClueText);
    }
}
