using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractNumpad : MonoBehaviour
{
    public GameObject goPadlock;
    public BoxCollider bcBoxTrigger;
    public GameObject goPlayer;
    // Start is called before the first frame update
    void Start()
    {
        goPadlock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other);
        if(other == goPlayer.GetComponent<CharacterController>())
        {
            goPlayer.GetComponent<playerMovement>().enableNumpadInteract(this);
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
    }

    //Quit out of the numpad with it incomplete
    public void Return()
    {
        goPadlock.SetActive(false);
        goPlayer.GetComponent<playerMovement>().enabled = true;
        Camera.main.GetComponent<mouseLook>().enabled = true;
        goPlayer.GetComponent<playerMovement>().disableNumpadInteract();
    }

    //Start the numpad puzzle
    public void turnOn()
    {
        goPadlock.SetActive(true);
        goPlayer.GetComponent<playerMovement>().enabled = false;
        Camera.main.GetComponent<mouseLook>().enabled = false;
    }
}
