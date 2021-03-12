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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if(other == goPlayer.GetComponent<CharacterController>())
        {
            goPadlock.SetActive(true);
            other.GetComponent<playerMovement>().enabled = false;
            Camera.main.GetComponent<mouseLook>().enabled = false;
        }
    }

    public void Deactivate()
    {
        goPadlock.SetActive(false);
        bcBoxTrigger.enabled = false;
        goPlayer.GetComponent<playerMovement>().enabled = true;
        Camera.main.GetComponent<mouseLook>().enabled = true;
    }

    public void Return()
    {
        goPadlock.SetActive(false);
        goPlayer.GetComponent<playerMovement>().enabled = true;
        Camera.main.GetComponent<mouseLook>().enabled = true;
    }
}
