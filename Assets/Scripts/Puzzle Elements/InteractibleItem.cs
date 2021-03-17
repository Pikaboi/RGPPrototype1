using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractibleItem : MonoBehaviour
{
    //Add doors here
    public GameObject[] trig;

    float timer = 0f;

    public Image ibuttonPrompt;
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

    void OnTriggerStay(Collider other)
    {
        //Check if the player is in the area
        if (other.tag == "Player")
        {
            //General practice to prevent a crash if no script is put on
            if (other.GetComponent<playerMovement>() != false)
            {
                //Show the button prompt
                ibuttonPrompt.enabled = true;
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
                //Show the button prompt
                ibuttonPrompt.enabled = false;
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
        for (int i = 0; i < trig.Length; i++) 
        {
            trig[i].GetComponent<resultant>().execute = true;
        }

       
        
    }

  
}
