using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractibleHint : MonoBehaviour
{
    //This is a button on the UI canvas to show you can interact
    public Image buttonPrompt;
    // Start is called before the first frame update
    void Start()
    {
        //Turn off the button at the start
        buttonPrompt.enabled = false;
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
            //Show the button prompt
            buttonPrompt.enabled = true;

            //Now we can allow the player to activate his button press in movement
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Check if the player left the interactible area
        if(other.tag == "Player")
        {
            //Remove the button promp
            buttonPrompt.enabled = false;

            //We want to turn off the ability to use the interact button too
        }
    }
}
