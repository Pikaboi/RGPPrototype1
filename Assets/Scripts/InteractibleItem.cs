﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleItem : MonoBehaviour
{
    //Its box collider
    private BoxCollider bcInteractArea;
    // Start is called before the first frame update
    void Start()
    {
        bcInteractArea = GetComponent<BoxCollider>();
        bcInteractArea.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Check if the player is in the area
        if (other.tag == "Player")
        {
            //General practice to prevent a crash if no script is put on
            if (other.GetComponent<playerMovement>() != false)
            {
                //Just like the Hints, we allow the player the power to interact with the item.
                other.GetComponent<playerMovement>().enableItemInteract(this);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Check if the player left the interactible area
        if (other.tag == "Player")
        {
            //General practice to prevent a crash if no script is put on
            if (other.GetComponent<playerMovement>() != false)
            {
                //Turn off the players ability to interact
                other.GetComponent<playerMovement>().disableItemInteract();
            }
        }
    }

    public void BecomeActive()
    {
        bcInteractArea.enabled = true;
    }

    public void interactCollect()
    {
        Debug.Log("2");
    }
}
