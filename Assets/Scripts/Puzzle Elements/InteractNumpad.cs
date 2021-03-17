using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractNumpad : MonoBehaviour
{
    public Image ibuttonPrompt;
    public GameObject goPadlock;
    public BoxCollider bcBoxTrigger;
    public GameObject goPlayer;
    // Start is called before the first frame update
    void Start()
    {
        goPadlock.SetActive(false);
        ibuttonPrompt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other == goPlayer.GetComponent<CharacterController>())
        {
            goPlayer.GetComponent<playerMovement>().enableNumpadInteract(this);
            if (goPadlock.activeSelf == false)
            {
                ibuttonPrompt.enabled = true;
            } else
            {
                ibuttonPrompt.enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == goPlayer.GetComponent<CharacterController>())
        {
            ibuttonPrompt.enabled = false;
            goPlayer.GetComponent<playerMovement>().disableNumpadInteract();
        }
    }

    //Turn off the collision when the player unlocks the puzzle
    public void Deactivate()
    {
        goPadlock.SetActive(false);
        bcBoxTrigger.enabled = false;
        goPlayer.GetComponent<playerMovement>().enabled = true;
        Camera.main.GetComponent<mouseLook>().enabled = true;
        goPlayer.GetComponent<playerMovement>().disableNumpadInteract();
        Cursor.lockState = CursorLockMode.Locked;
        ibuttonPrompt.enabled = false;
    }

    //Quit out of the numpad with it incomplete
    public void Return()
    {
        goPadlock.SetActive(false);
        goPlayer.GetComponent<playerMovement>().enabled = true;
        Camera.main.GetComponent<mouseLook>().enabled = true;
        goPlayer.GetComponent<playerMovement>().disableNumpadInteract();
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Start the numpad puzzle
    public void turnOn()
    {
        goPadlock.SetActive(true);
        goPlayer.GetComponent<playerMovement>().enabled = false;
        Camera.main.GetComponent<mouseLook>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
}
